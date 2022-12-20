using System;
using System.IO;
using System.Text;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;

namespace CRMSDKPractice
{
    public class Program
    {
        public enum gendercodetype
        {
            Male = 1,
            Female = 2,
            Other = 3
        }

        static void Main(string[] args)
        {
            try
            {
                // e.g. https://yourorg.crm.dynamics.com
                string url = "https://harichandan.crm.dynamics.com";
                // e.g. you@yourorg.onmicrosoft.com
                string userName = "HarichandanSriramula@Techxacts399.onmicrosoft.com";
                // e.g. y0urp455w0rd 
                string password = "nanihari@0509";
                string conn = $@"
                               Url = {url};
                          AuthType = OAuth;
                          UserName = {userName};
                          Password = {password};
                          AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
                          RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
                          LoginPrompt=Auto;
                          RequireNewInstance = True";
                using (var crmServiceClient = new CrmServiceClient(conn))
                {
                    if (crmServiceClient.IsReady)
                    {
                        QueryExpression contactExpression = new QueryExpression("tech_itmeentry");
                        contactExpression.ColumnSet.AddColumn("tech_approvalstatus");
                        contactExpression.Criteria.AddCondition("tech_approvalstatus", ConditionOperator.Equal, 1);
                        contactExpression.Criteria.AddCondition("tech_contactid", ConditionOperator.Equal, new Guid("F850D5C4-4A36-ED11-9DB1-002248081155"));
                        EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(contactExpression);
                        Console.WriteLine("count :"+entityCollection.Entities.Count);

                        //ReadFiles(crmServiceClient);
                        //Entity customer = new Entity("hcn_customer");
                        //Guid customerId = CreateCustomer(crmServiceClient);
                        //Console.WriteLine("Customer created with ID" + customerId);

                        //Entity updatedCustomer = new Entity("hcn_customer");
                        //updatedCustomer = crmServiceClient.Retrieve(customer.LogicalName, customerId, new ColumnSet(true));
                        //updatedCustomer["hcn_otherdetails"] = "Hi nana.\nHow are you?\nHow you doing?";
                        //crmServiceClient.Update(updatedCustomer);
                        //Console.WriteLine("Updated Customer");

                        // printcustomer(customer);
                        //Entity customer = RetrieveRecord(crmServiceClient);
                        //if (customer != null)
                        //{
                        //    printcustomer(customer);
                        //printcustomer1(customer);
                        //Retrieverecords(crmServiceClient);
                        //Retrieverecords1(crmServiceClient);
                        //}
                        //Selectcustomer(crmServiceClient);
                        // Guid opportunityid = CreateOpportunity(crmServiceClient);
                        // Console.WriteLine("opportunity created with ID" + opportunityid);
                        //GetContact(crmServiceClient);
                        //SetOppurtunityState(crmServiceClient);                       
                        //GetAccountRecords(crmServiceClient);
                        //GetOpenActivities(crmServiceClient);
                        //CreateAllActivities(crmServiceClient);
                        //UpdateAccountOrContact(crmServiceClient);                       
                        // GetLeadRecords(crmServiceClient);
                        //GetContactsbyAccount(crmServiceClient);
                        //DuplicateContactRecords(crmServiceClient);
                        //GetAllOpenActivities_CurrentUser(crmServiceClient);
                        //AssignRecord(crmServiceClient);
                        //RandomNumUpdateAccount(crmServiceClient);
                        //CreateAndSendEmail(crmServiceClient);
                        //Modifycontact(crmServiceClient);
                        // GetFirstRecord(crmServiceClient);
                        Console.WriteLine("press any key to exit");
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static Guid CreateCustomer(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                string gender = string.Empty;
                int gendercode = 0;

                Console.WriteLine("Enter your firstname:");
                string firstname = Console.ReadLine();

                Console.WriteLine("Enter your lastname:");
                string lastname = Console.ReadLine();

                Console.WriteLine("Enter your Gender:");
                gender = Console.ReadLine();

                Console.WriteLine("Enter your Totalfee:");
                decimal Totalfees = decimal.Parse(Console.ReadLine());

                OptionSetValueCollection sportsinterstedin = new OptionSetValueCollection();
                sportsinterstedin.Add(new OptionSetValue(1));
                sportsinterstedin.Add(new OptionSetValue(2));
                sportsinterstedin.Add(new OptionSetValue(3));

                if (gender == "Male")
                {
                    gendercode = Convert.ToInt32(gendercodetype.Male);
                }
                else if (gender == "Female")
                {
                    gendercode = Convert.ToInt32(gendercodetype.Female);
                }
                else if (gender == "Other")
                {
                    gendercode = Convert.ToInt32(gendercodetype.Other);
                }

                Entity customer = new Entity("hcn_customer");
                customer.Attributes["hcn_firstname"] = firstname;
                customer.Attributes["hcn_lastname"] = lastname;
                customer.Attributes["hcn_otherdetails"] = "Hi nana.\nHow are you?";
                customer.Attributes["hcn_gender"] = new OptionSetValue(gendercode);
                customer.Attributes["hcn_customerlocation"] = new OptionSetValue(801110002);
                customer.Attributes["hcn_joiningdate"] = DateTime.Now;
                customer.Attributes["hcn_sportsinterestedin"] = sportsinterstedin;
                customer.Attributes["hcn_totalfees"] = new Money(Totalfees);
                customer.Attributes["hcn_company"] = new EntityReference("account", new Guid("4dd160f3-eb25-ed11-b83e-000d3a5a7348"));
                customer.Attributes["hcn_customer"] = new EntityReference("contact", new Guid("61fd8c0e-f525-ed11-b83e-000d3a5a7348"));
                customer.Attributes["hcn_height"] = Convert.ToDecimal(5.2);
                customer.Attributes["hcn_weight"] = Convert.ToDouble(40.5);
                return crmServiceClient.Create(customer);
                //Console.WriteLine("Your Customer created successfully with Id : " + customerId);

            }
            else
            {
                return Guid.Empty;
            }
        }

        private static Entity RetrieveRecord(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                Console.WriteLine("Enter CustomerID :");
                var recordId = Console.ReadLine();
                Guid customerId = new Guid(recordId);
                ColumnSet columnSet = new ColumnSet();
                columnSet.AddColumns(new string[] { "hcn_firstname", "hcn_lastname", "hcn_gender", "hcn_customerlocation", "hcn_joiningdate", "hcn_sportsinterestedin", "hcn_totalfees", "hcn_company", "hcn_customer" });
                string entitylogicalname = "hcn_customer";
                return crmServiceClient.Retrieve(entitylogicalname, customerId, columnSet);

            }
            else
            {
                return null;
            }
        }

        private static void printcustomer1(Entity customer)
        {
            string firstname = customer.Contains("hcn_firstname") ? Convert.ToString(customer["hcn_firstname"]) : string.Empty;
            string lastname = customer.Contains("hcn_lastname") ? Convert.ToString(customer["hcn_lastname"]) : string.Empty;
            string gender = customer.Contains("hcn_gender") ? Convert.ToString(customer["hcn_gender"]) : string.Empty;
            DateTime joiningdate = customer.Contains("hcn_joiningdate") ? Convert.ToDateTime(customer["hcn_joiningdate"]) : DateTime.Now;
            string lookupname = customer.Attributes.Contains("hcn_company") ? (customer.Attributes["hcn_company"] as EntityReference).Name : string.Empty;
            Guid lookupId = customer.Attributes.Contains("hcn_company") ? (customer.Attributes["hcn_company"] as EntityReference).Id : Guid.Empty;
            string sportsinterestedintext = customer.FormattedValues.Contains("hcn_sportsinterestedin") ? (customer.FormattedValues["hcn_sportsinterestedin"]) : string.Empty;
            decimal totalfees = customer.FormattedValues.Contains("hcn_totalfees") ? (customer.Attributes["hcn_totalfees"] as Money).Value : 0;
        }

        private static void printcustomer(Entity customer)
        {
            string firstname = Convert.ToString(customer["hcn_firstname"]);
            Console.WriteLine($"customer firstname :{firstname}");

            string lastname = Convert.ToString(customer["hcn_lastname"]);
            Console.WriteLine("customer lastname :" + lastname);

            int gender = (customer.Attributes["hcn_gender"] as OptionSetValue).Value;
            Console.WriteLine("customer gender :" + gender);

            DateTime joiningdate = Convert.ToDateTime(customer.Attributes["hcn_joiningdate"]);
            Console.WriteLine("customer joiningdate :" + joiningdate);

            string lookupname = (customer.Attributes["hcn_company"] as EntityReference).Name;
            Console.WriteLine("customer lookupname :" + lookupname);

            Guid lookupId = (customer.Attributes["hcn_company"] as EntityReference).Id;
            Console.WriteLine("customer lookupId :" + lookupId);

            string sportsinterestedintext = (customer.FormattedValues["hcn_sportsinterestedin"]);
            Console.WriteLine("customer sportsinterestedin text :" + sportsinterestedintext);

            string sportsinterestedinvalue = string.Empty;
            OptionSetValueCollection optionSetValues = customer.Attributes["hcn_sportsinterestedin"] as OptionSetValueCollection;
            foreach (OptionSetValue optvalues in optionSetValues)
            {
                sportsinterestedinvalue = sportsinterestedinvalue + optvalues.Value.ToString();
            }
            Console.WriteLine("customer sportsinterestedin value  :" + sportsinterestedinvalue);

            decimal totalfees = (customer.Attributes["hcn_totalfees"] as Money).Value;
            Console.WriteLine("customer totalfees:" + totalfees);
        }

        private static void Retrieverecords(CrmServiceClient crmServiceClient)
        {
            string fetchxml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>" +
                                    "<entity name='hcn_customer'>" +
                                      "<attribute name='hcn_customerid' />" +
                                      "<attribute name='hcn_firstname' />" +
                                     "<attribute name='createdon' />" +
                                      "<attribute name='statuscode' />" +
                                      "<order attribute='statuscode' descending='false' />" +
                                    "</entity>" +
                                "</fetch>";
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchxml));
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (Entity customer in entityCollection.Entities)
                {
                    string firstname = customer.Contains("hcn_firstname") ? Convert.ToString(customer["hcn_firstname"]) : string.Empty;
                    Console.WriteLine($"customer firstname :{firstname}");
                    string statuscode = customer.Attributes.Contains("statuscode") ? Convert.ToString(customer.FormattedValues["statuscode"]) : string.Empty;
                    Console.WriteLine($"customer statuscode :{statuscode}");
                }
            }
        }

        private static void Retrieverecords1(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("hcn_customer");
            queryExpression.ColumnSet.AddColumns(new string[] { "hcn_firstname", "createdon", "statuscode" });
            queryExpression.AddOrder("statuscode", OrderType.Ascending);
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                Console.WriteLine("Total Records :" + entityCollection.Entities.Count);
                int sno = 0;
                foreach (Entity customer in entityCollection.Entities)
                {
                    string firstname = customer.Contains("hcn_firstname") ? Convert.ToString(customer["hcn_firstname"]) : string.Empty;
                    string statuscode = customer.Attributes.Contains("statuscode") ? Convert.ToString(customer.FormattedValues["statuscode"]) : string.Empty;
                    Console.WriteLine($"{sno}-customer firstname :{firstname},status {statuscode}");
                    sno = sno + 1;
                }
            }
        }

        private static void GetContact(CrmServiceClient crmServiceClient)
        {
            //to get current user
            QueryExpression queryExpression = new QueryExpression("contact");
            //queryExpression.Criteria.AddCondition("ownerid", ConditionOperator.Equal, crmServiceClient.GetMyCrmUserId());
            //Example:1
            queryExpression.ColumnSet.AllColumns = true;
            queryExpression.Criteria.AddCondition("familystatuscode", ConditionOperator.Equal, 1);
            queryExpression.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);
            FilterExpression filterExpression = new FilterExpression(LogicalOperator.Or);
            filterExpression.AddCondition("telephone2", ConditionOperator.Null);
            filterExpression.AddCondition("home2", ConditionOperator.Null);
            queryExpression.Criteria.AddFilter(filterExpression);
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    //Console.WriteLine("No of Records: "+entityCollection.Entities.Count);
                    string firstname = Convert.ToString(entity.Attributes["firstname"]);
                    Console.WriteLine(firstname);
                }
            }
        }

        private static Guid CreateOpportunity(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                Entity opportunity = new Entity("opportunity");
                opportunity.Attributes["name"] = "CRM";
                opportunity.Attributes["isrevenuesystemcalculated"] = true;
                opportunity.Attributes["pricelevelid"] = new EntityReference("pricelevel", new Guid("f377a643-1de7-e611-80f4-e0071b661f01"));
                EntityReference entityReference = new EntityReference { Id = new Guid("bd2aa1c2-3b1a-ed11-b83c-000d3a3362c8"), LogicalName = "contact" };
                opportunity.Attributes["customerid"] = entityReference;
                opportunity.Attributes["discountamount"] = new Money(28454);
                opportunity.Attributes["discountpercentage"] = Convert.ToDecimal(50.0);
                opportunity.Attributes["freightamount"] = new Money(1230234);
                opportunity.Attributes["estimatedvalue"] = new Money(1546689);
                return crmServiceClient.Create(opportunity);

            }
            else
            {
                return Guid.Empty;
            }
        }

        private static void SetOppurtunityState(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                QueryExpression setstatequery = new QueryExpression("opportunity");
                setstatequery.ColumnSet.AddColumns(new string[] { "name", "statuscode", "statecode" });
                setstatequery.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);
                EntityCollection entitycollection = crmServiceClient.RetrieveMultiple(setstatequery);
                if (entitycollection != null && entitycollection.Entities != null && entitycollection.Entities.Count > 0)
                {
                    foreach (var entity in entitycollection.Entities)
                    {
                        updateoppurtunitystatus(crmServiceClient, entity);
                    }
                }
            }
        }

        private static void updateoppurtunitystatus(CrmServiceClient crmServiceClient, Entity entity)
        {
            SetStateRequest req = new SetStateRequest();
            req.EntityMoniker = new EntityReference(entity.LogicalName, entity.Id);
            req.State = new OptionSetValue(1);
            req.Status = new OptionSetValue(3);
            crmServiceClient.Execute(req);
        }

        private static void GetAccountRecords(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                QueryExpression queryExpression = new QueryExpression("account");
                queryExpression.ColumnSet.AddColumns(new string[] { "primarycontactid", "telephone1" });
                FilterExpression filterExpression = new FilterExpression(LogicalOperator.Or);
                filterExpression.AddCondition("primarycontactid", ConditionOperator.Null);
                filterExpression.AddCondition("telephone1", ConditionOperator.Null);
                queryExpression.Criteria.AddFilter(filterExpression);
                EntityCollection entitycollection = crmServiceClient.RetrieveMultiple(queryExpression);
                if (entitycollection != null && entitycollection.Entities != null && entitycollection.Entities.Count > 0)
                {
                    foreach (var entity in entitycollection.Entities)
                    {
                        UpdateAccount(crmServiceClient, entity);
                    }
                }
            }
        }

        private static void UpdateAccount(CrmServiceClient crmServiceClient, Entity entity)
        {
            entity["primarycontactid"] = new EntityReference("contact", new Guid("61492847-ee13-ed11-b83d-000d3a3b0897"));
            entity["telephone1"] = "9666691837";
            crmServiceClient.Update(entity);
        }

        private static void GetOpenActivities(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                QueryExpression queryExpression = new QueryExpression("activitypointer");
                queryExpression.ColumnSet.AddColumns(new string[] { "regardingobjectid", "statecode", "activitytypecode" });
                FilterExpression filterExpression = new FilterExpression(LogicalOperator.And);
                filterExpression.AddCondition("regardingobjectid", ConditionOperator.Equal, new Guid("E14644C8-ED13-ED11-B83D-000D3A3B0897"));
                filterExpression.AddCondition("statecode", ConditionOperator.Equal, 0);
                queryExpression.Criteria.AddFilter(filterExpression);
                EntityCollection entitycollection = crmServiceClient.RetrieveMultiple(queryExpression);
                if (entitycollection != null && entitycollection.Entities != null && entitycollection.Entities.Count > 0)
                {
                    foreach (var entity in entitycollection.Entities)
                    {
                        string activitySchemaName = entity.GetAttributeValue<string>("activitytypecode");
                        SetStateRequest req = new SetStateRequest();
                        req.EntityMoniker = new EntityReference(activitySchemaName, entity.Id);
                        if (activitySchemaName == "task")
                        {
                            req.State = new OptionSetValue(1);
                            req.Status = new OptionSetValue(5);
                        }
                        else if (activitySchemaName == "email")
                        {
                            req.State = new OptionSetValue(1);
                            req.Status = new OptionSetValue(2);
                        }
                        else if (activitySchemaName == "phonecall")
                        {
                            req.State = new OptionSetValue(1);
                            req.Status = new OptionSetValue(2);
                        }
                        else if (activitySchemaName == "letter")
                        {
                            req.State = new OptionSetValue(1);
                            req.Status = new OptionSetValue(3);
                        }
                        else if (activitySchemaName == "fax")
                        {
                            req.State = new OptionSetValue(1);
                            req.Status = new OptionSetValue(2);
                        }
                        crmServiceClient.Execute(req);
                    }
                }
            }
        }

        private static void UpdateActivitystatus(CrmServiceClient crmServiceClient, Entity entity)
        {
            entity["statecode"] = new OptionSetValue(1);
            crmServiceClient.Update(entity);
        }

        private static Guid CreateAccount(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                Entity account = new Entity("account");
                account.Attributes["name"] = "Sony";
                return crmServiceClient.Create(account);
            }
            else
            {
                return Guid.Empty;
            }
        }

        private static Guid CreateContact(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                Entity contact = new Entity("contact");
                contact.Attributes["firstname"] = "Sony";//
                contact.Attributes["lastname"] = "MI";
                return crmServiceClient.Create(contact);
            }
            else
            {
                return Guid.Empty;
            }
        }

        private static void UpdateAccountOrContact(CrmServiceClient crmServiceClient)
        {
            Guid accountId = CreateAccount(crmServiceClient);
            Guid contactId = CreateContact(crmServiceClient);
            if (accountId != null)
            {
                Entity account = new Entity("account");
                account = crmServiceClient.Retrieve(account.LogicalName, accountId, new ColumnSet(true));
                account["primarycontactid"] = new EntityReference("contact", contactId);
                crmServiceClient.Update(account);
            }
            if (contactId != null)
            {
                Entity contact = new Entity("contact");
                contact = crmServiceClient.Retrieve(contact.LogicalName, contactId, new ColumnSet(true));
                contact["parentcustomerid"] = new EntityReference("account", accountId);
                crmServiceClient.Update(contact);
            }
        }

        private static void CreateTask(CrmServiceClient crmServiceClient, Guid regardingobjectid, string logicalname)
        {
            Entity followup = new Entity("task");
            followup["subject"] = "Send e-mail to the new customer.";
            followup["description"] = "Follow up with the customer. Check if there are any new issues that need resolution.";
            followup["regardingobjectid"] = new EntityReference(logicalname, regardingobjectid);
            crmServiceClient.Create(followup);
        }

        private static void CreateEmail(CrmServiceClient crmServiceClient, Guid regardingobjectid, string Logicalname)
        {
            if (crmServiceClient.IsReady)
            {
                Entity email = new Entity("email");
                Entity fromActivityprty = new Entity("activityparty");
                Entity toActivityParty = new Entity("activityparty");
                fromActivityprty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                toActivityParty["partyid"] = new EntityReference(Logicalname, regardingobjectid);
                email["from"] = new Entity[] { fromActivityprty };
                email["to"] = new Entity[] { toActivityParty };
                email["regardingobjectid"] = new EntityReference(Logicalname, regardingobjectid);
                email["subject"] = "This is subject.";
                email["description"] = "This is description";
                email["directioncode"] = true;
                crmServiceClient.Create(email);
            }
        }

        private static void CreatePhoneCall(CrmServiceClient crmServiceClient, Guid regardingobjectid, string Logicalname)
        {
            if (crmServiceClient.IsReady)
            {
                Entity phonecall = new Entity("phonecall");
                Entity fromActivityprty = new Entity("activityparty");
                Entity toActivityParty = new Entity("activityparty");
                fromActivityprty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                toActivityParty["partyid"] = new EntityReference(Logicalname, regardingobjectid);
                phonecall["from"] = new Entity[] { fromActivityprty };
                phonecall["to"] = new Entity[] { toActivityParty };
                phonecall["regardingobjectid"] = new EntityReference(Logicalname, regardingobjectid);
                phonecall["subject"] = "This is subject.";
                phonecall["description"] = "This is description";
                crmServiceClient.Create(phonecall);
            }
        }

        private static void CreateLetter(CrmServiceClient crmServiceClient, Guid regardingobjectid, string Logicalname)
        {
            if (crmServiceClient.IsReady)
            {
                Entity letter = new Entity("letter");
                Entity fromActivityprty = new Entity("activityparty");
                Entity toActivityParty = new Entity("activityparty");
                fromActivityprty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                toActivityParty["partyid"] = new EntityReference(Logicalname, regardingobjectid);
                letter["from"] = new Entity[] { fromActivityprty };
                letter["to"] = new Entity[] { toActivityParty };
                letter["regardingobjectid"] = new EntityReference(Logicalname, regardingobjectid);
                letter["subject"] = "Letter activity 06/10/22.";
                letter["description"] = "Information";
                crmServiceClient.Create(letter);
            }
        }

        private static void CreateFax(CrmServiceClient crmServiceClient, Guid regardingobjectid, string Logicalname)
        {
            if (crmServiceClient.IsReady)
            {
                Entity fax = new Entity("fax");
                Entity fromActivityprty = new Entity("activityparty");
                Entity toActivityParty = new Entity("activityparty");
                fromActivityprty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                toActivityParty["partyid"] = new EntityReference(Logicalname, regardingobjectid);
                fax["from"] = new Entity[] { fromActivityprty };
                fax["regardingobjectid"] = new EntityReference(Logicalname, regardingobjectid);
                fax["subject"] = "Fax activity 06/10/22.";
                fax["description"] = "Information";
                crmServiceClient.Create(fax);
            }
        }

        private static void CreateAllActivities(CrmServiceClient crmServiceClient)
        {
            Guid accountId = CreateAccount(crmServiceClient);
            Guid contactId = CreateContact(crmServiceClient);
            if (accountId != null)
            {
                CreateTask(crmServiceClient, accountId, "account");
                CreateEmail(crmServiceClient, accountId, "account");
                CreatePhoneCall(crmServiceClient, accountId, "account");
                CreateLetter(crmServiceClient, accountId, "account");
                CreateFax(crmServiceClient, accountId, "account");
            }
            if (contactId != null)
            {
                CreateTask(crmServiceClient, contactId, "contact");
                CreateEmail(crmServiceClient, contactId, "contact");
                CreatePhoneCall(crmServiceClient, contactId, "contact");
                CreateLetter(crmServiceClient, contactId, "contact");
                CreateFax(crmServiceClient, contactId, "contact");
            }
        }

        private static void bulkupdate(CrmServiceClient crmServiceClient, EntityCollection entityCollection)
        {
            ExecuteMultipleRequest multipleRequest = new ExecuteMultipleRequest()
            {
                // Assign settings that define execution behavior: continue on error, return responses. 
                Settings = new ExecuteMultipleSettings()
                {
                    ContinueOnError = false,
                    ReturnResponses = true
                },
                // Create an empty organization request collection.
                Requests = new OrganizationRequestCollection()
            };

            // Add a CreateRequest for each entity to the request collection.
            foreach (var entity in entityCollection.Entities)
            {
                Entity updatedrecord = new Entity("lead");
                updatedrecord.Id = entity.Id;
                updatedrecord["mobilephone"] = "9666691837";
                UpdateRequest createRequest = new UpdateRequest { Target = updatedrecord };
                multipleRequest.Requests.Add(createRequest);
            }

            // Execute all the requests in the request collection using a single web method call.
            ExecuteMultipleResponse multipleResponse = (ExecuteMultipleResponse)crmServiceClient.Execute(multipleRequest);

        }

        private static void GetLeadRecords(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("lead");
            queryExpression.ColumnSet.AllColumns = true;
            queryExpression.Criteria.AddCondition("mobilephone", ConditionOperator.Null);
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    bulkupdate(crmServiceClient, entityCollection);
                }
            }
        }

        private static void DuplicateContactRecords(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                Console.WriteLine("Enter your  fullname");
                string fullname = Console.ReadLine();
                Console.WriteLine("Enter your emailaddress");
                string emailaddress = Console.ReadLine();
                QueryExpression queyexpression = new QueryExpression("contact");
                queyexpression.Criteria.AddCondition("fullname", ConditionOperator.Equal, fullname);
                queyexpression.Criteria.AddCondition("emailaddress1", ConditionOperator.Equal, emailaddress);
                EntityCollection record = crmServiceClient.RetrieveMultiple(queyexpression);
                if (record.Entities.Count > 0)
                {
                    Console.WriteLine("Duplicate Records are Found.Please check!");
                }
            }

        }

        private static void GetContactsbyAccount(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("contact");
            queryExpression.ColumnSet.AddColumns(new string[] { "firstname", "lastname", "parentcustomerid" });
            queryExpression.Criteria.AddCondition("parentcustomerid", ConditionOperator.Equal, new Guid("e24644c8-ed13-ed11-b83d-000d3a3b0897"));
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    string firstname = Convert.ToString(entity.Attributes["firstname"]);
                    string lastname = Convert.ToString(entity.Attributes["lastname"]);
                    Console.WriteLine("Fullname :" + firstname + " " + lastname);
                }
            }
        }

        private static void GetAllOpenActivities_CurrentUser(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("activitypointer");
            queryExpression.ColumnSet.AddColumns(new string[] { "statecode", "ownerid", "activitytypecode" });
            FilterExpression filterExpression = new FilterExpression(LogicalOperator.And);
            filterExpression.AddCondition("ownerid", ConditionOperator.Equal, crmServiceClient.GetMyCrmUserId());
            filterExpression.AddCondition("statecode", ConditionOperator.Equal, 0);
            queryExpression.Criteria.AddFilter(filterExpression);
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    string activitySchemaName = entity.GetAttributeValue<string>("activitytypecode");
                    SetStateRequest req = new SetStateRequest();
                    req.EntityMoniker = new EntityReference(activitySchemaName, entity.Id);
                    if (activitySchemaName == "task")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(5);
                    }
                    else if (activitySchemaName == "email")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(2);
                    }
                    else if (activitySchemaName == "phonecall")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(2);
                    }
                    else if (activitySchemaName == "letter")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(3);
                    }
                    else if (activitySchemaName == "fax")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(2);
                    }
                    else if (activitySchemaName == "cdi_customerreport")
                    {
                        req.State = new OptionSetValue(1);
                        req.Status = new OptionSetValue(2);
                    }
                    crmServiceClient.Execute(req);
                }
            }
        }

        private static void AssignRecord(CrmServiceClient crmServiceClient)
        {
            try
            {
                Entity contact = new Entity("contact");
                Guid OwningTeamID = new Guid("6C593E19-2813-ED11-B83D-000D3A3B0897");
                QueryExpression queryExpression = new QueryExpression("contact");
                queryExpression.ColumnSet.AllColumns = true;
                EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
                if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
                {
                    foreach (var entity in entityCollection.Entities)
                    {
                        Guid TargetRecordId = entity.Id;
                        AssignRequest assign = new AssignRequest
                        {
                            Assignee = new EntityReference("systemuser", OwningTeamID),
                            Target = new EntityReference(contact.LogicalName, TargetRecordId)
                        };
                        crmServiceClient.Execute(assign);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while assinging Team to a record." + ex.Message);
            }
        }

        private static void CreateAndSendEmail(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                var contactId = "e968cebb-a53c-ed11-9db0-000d3a35cc1d";
                Entity email = new Entity("email");
                Entity fromActivityparty = new Entity("activityparty");
                Entity toActivityParty = new Entity("activityparty");
                fromActivityparty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                toActivityParty["partyid"] = new EntityReference("contact", new Guid(contactId));
                email["from"] = new Entity[] { fromActivityparty };
                email["to"] = new Entity[] { toActivityParty };
                email["regardingobjectid"] = new EntityReference("contact", new Guid(contactId));
                email["subject"] = "CRM Training";
                email["description"] = "Hello,CRM training is going from tomorrow.";
                email["directioncode"] = true;
                Guid emailId = crmServiceClient.Create(email);
                SendEmailRequest sendEmailRequest = new SendEmailRequest
                {
                    EmailId = emailId,
                    TrackingToken = "",
                    IssueSend = true
                };
                SendEmailResponse sendEmailresp = (SendEmailResponse)crmServiceClient.Execute(sendEmailRequest);
                Console.WriteLine("Email sent successfully.");
                Console.ReadLine();
            }
        }

        private static void RandomNumUpdateAccount(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("account");
            queryExpression.ColumnSet.AddColumns(new string[] { "accountnumber" });
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    Random randomNum = new Random();
                    int num = randomNum.Next();
                    entity["accountnumber"] = Convert.ToString(num);
                    crmServiceClient.Update(entity);
                }
            }
        }

        private static void Modifycontact(CrmServiceClient crmServiceClient)
        {
            if (crmServiceClient.IsReady)
            {
                QueryExpression queryExpression = new QueryExpression("contact");
                queryExpression.ColumnSet.AddColumns(new string[] { "address1_stateorprovince" });
                queryExpression.Criteria.AddCondition("address1_stateorprovince", ConditionOperator.Equal, "Telangana");
                EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
                if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
                {
                    Entity email = new Entity("email");
                    Entity fromActivityprty = new Entity("activityparty");
                    Entity toActivityParty = new Entity("activityparty");
                    fromActivityprty["partyid"] = new EntityReference("systemuser", crmServiceClient.GetMyCrmUserId());
                    toActivityParty["partyid"] = new EntityReference("contact", new Guid("aba1537e-e317-ed11-b83e-000d3a34c05b"));
                    email["from"] = new Entity[] { fromActivityprty };
                    email["to"] = new Entity[] { toActivityParty };
                    EntityCollection cc = new EntityCollection();
                    foreach (var entity in entityCollection.Entities)
                    {
                        Entity ccActivityparty = new Entity("activityparty");
                        ccActivityparty["partyid"] = new EntityReference(entity.LogicalName, entity.Id);
                        cc.Entities.Add(ccActivityparty);
                    }
                    email["cc"] = cc;
                    email["regardingobjectid"] = new EntityReference("contact", new Guid("aba1537e-e317-ed11-b83e-000d3a34c05b"));
                    email["subject"] = "This is subject.";
                    email["description"] = "This is description";
                    email["directioncode"] = true;
                    crmServiceClient.Create(email);
                }
            }
        }

        private static void GetFirstRecord(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("lead");
            queryExpression.ColumnSet.AddColumns(new string[] { "mobilephone" });
            queryExpression.Criteria.AddCondition("mobilephone", ConditionOperator.NotNull);
            var entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                foreach (var entity in entityCollection.Entities)
                {
                    string sdv = entityCollection[0].Attributes["mobilephone"].ToString();
                    //Guid firstGuid = entityCollection[0].Id;
                    Console.WriteLine("firstGuid :" + sdv);
                }
            }
        }

        private static void ReadFiles(CrmServiceClient crmServiceClient)
        {
            string path = @"D:\Console";
            string[] s = Directory.GetFiles(path);

            // Create an email
            Entity email = new Entity("email");
            email["subject"] = "Creating email from Console!";
            email["description"] = "Reading files from local and attaching files to the email.";
            email["directioncode"] = true;
            Guid emailId = crmServiceClient.Create(email);

            // Read all the file contents
            foreach (string file in s)
            {
                string extension = Path.GetExtension(file);
                string mimeType = getMimeType(extension);
                string base64 = convertToBase64(file);

                Entity emailAttachment = new Entity("activitymimeattachment");
                emailAttachment["filename"] = Path.GetFileName(file);
                emailAttachment["mimetype"] = mimeType;
                emailAttachment["body"] = base64;
                emailAttachment["objecttypecode"] = "email";
                emailAttachment["objectid"] = new EntityReference("email", emailId);
                Guid id = crmServiceClient.Create(emailAttachment);
            }
        }
        static string getMimeType(string extension)
        {
            string mimeType = "application/unknown";
            string ext = extension.ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }
        static string convertToBase64(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            string base64 = Convert.ToBase64String(bytes);
            return base64;
        }
    }
}
