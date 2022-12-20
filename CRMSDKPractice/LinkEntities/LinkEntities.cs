using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;

namespace CRMSDKPractice
{
    public class LinkEntities
    {
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
                        //GetUserRolesFetchXML(crmServiceClient);
                        GetUserRoles(crmServiceClient);
                        //GetUserTeamsFetchXML(crmServiceClient);
                        //GetUserTeam(crmServiceClient);
                       // Accounts_ContainsPrimaryContactFetchXML(crmServiceClient);
                        //Accounts_ContainsPrimaryContact(crmServiceClient);
                        //Contacts_ContainsCompanyFetchXML(crmServiceClient);
                        //Contacts_ContainsCompany(crmServiceClient);
                    }
                }
                Console.WriteLine("press any key to exit");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static void GetUserRolesFetchXML(CrmServiceClient crmServiceClient)
        {
            string fetchXML = "<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='true'>" +
                              "<entity name='role'>" +
                                "<attribute name='name' />" +
                                "<attribute name='businessunitid' />" +
                                "<attribute name='roleid' />" +
                                "<order attribute='name' descending='false' />" +
                                "<link-entity name='systemuserroles' from='roleid' to='roleid' visible='false' intersect='true'>" +
                                  "<link-entity name='systemuser' from='systemuserid' to='systemuserid' alias='ay'>" +
                                    "<filter type='and'>" +
                                      "<condition attribute='isdisabled' operator='eq' value='0' />" +
                                    "</filter>" +
                                  "</link-entity>" +
                                "</link-entity>" +
                              "</entity>" +
                            "</fetch>";
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXML));
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNo = 1;
                foreach (Entity roles in entityCollection.Entities)
                {
                    string securityRole = roles.Contains("name") ? Convert.ToString(roles["name"]) : string.Empty;
                    Console.WriteLine($"{sNo }:Enable user security role :{securityRole}");
                    sNo++;
                }
            }
        }

        private static void GetUserRoles(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("role");
            queryExpression.ColumnSet.AddColumns(new string[] { "name" });
            queryExpression.AddOrder("name", OrderType.Ascending);

            LinkEntity linkEntityRoles = new LinkEntity();
            linkEntityRoles.LinkFromEntityName = "role";
            linkEntityRoles.LinkToEntityName = "systemuserroles";
            linkEntityRoles.LinkFromAttributeName = "roleid";
            linkEntityRoles.LinkToAttributeName = "roleid";

            LinkEntity linkEntity = new LinkEntity();
            linkEntity.LinkFromEntityName = "systemuserroles";
            linkEntity.LinkToEntityName = "systemuser";
            linkEntity.LinkFromAttributeName = "systemuserid";
            linkEntity.LinkToAttributeName = "systemuserid";
            linkEntity.EntityAlias = "hs";
            linkEntity.Columns = new ColumnSet(new string[] { "isdisabled","fullname" });
            linkEntity.LinkCriteria.AddCondition("isdisabled", ConditionOperator.Equal, false);

            linkEntityRoles.LinkEntities.Add(linkEntity);
            queryExpression.LinkEntities.Add(linkEntityRoles);

            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                for (int i = 0; i < entityCollection.Entities.Count; i++)
                {
                    string rolename = entityCollection.Entities[3]["name"].ToString();
                    Console.WriteLine(rolename[5]);
                }
                //foreach (var entity in entityCollection.Entities)
                //{
                //    int sNo = 0;
                //    string fullname = entity.Contains("hs.fullname") ? Convert.ToString((entity["hs.fullname"] as AliasedValue).Value) : string.Empty;
                //    string rolename = entity.Contains("name") ? Convert.ToString(entity["name"]) : string.Empty;
                //    Console.WriteLine($"{sNo}Fullname :{fullname},Enable Users Securityroles: {rolename}");
                //    sNo++;
                //}
            }
        }

        private static void GetUserTeamsFetchXML(CrmServiceClient crmServiceClient)
        {
            string fetchxml = "<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='true'>" +
                                  "<entity name='team'>" +
                                    "<attribute name='name' />" +
                                    "<attribute name='businessunitid' />" +
                                    "<attribute name='teamid' />" +
                                    "<attribute name='teamtype' />" +
                                    "<order attribute='name' descending='false' />" +
                                    "<link-entity name='teammembership' from='teamid' to='teamid' visible='false' intersect='true'>" +
                                      "<link-entity name='systemuser' from='systemuserid' to='systemuserid' alias='ah'>" +
                                        "<filter type='and'>" +
                                          "<condition attribute='isdisabled' operator='eq' value='0' />" +
                                        "</filter>" +
                                      "</link-entity>" +
                                    "</link-entity>" +
                                  "</entity>" +
                                "</fetch>";
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchxml));
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNO = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string teams = entity.Contains("name") ? Convert.ToString(entity["name"]) : string.Empty;
                    Console.WriteLine($"{sNO}Enable Users teams: {teams}");
                    sNO++;
                }
            }
        }

        private static void GetUserTeam(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("team");
            queryExpression.ColumnSet.AddColumns(new string[] { "name" });
            queryExpression.AddOrder("name", OrderType.Ascending);

            LinkEntity linkEntityRoles = new LinkEntity();
            linkEntityRoles.LinkFromEntityName = "team";
            linkEntityRoles.LinkToEntityName = "teammembership";
            linkEntityRoles.LinkFromAttributeName = "teamid";
            linkEntityRoles.LinkToAttributeName = "teamid";

            LinkEntity linkEntity = new LinkEntity();
            linkEntity.LinkFromEntityName = "teammembership";
            linkEntity.LinkToEntityName = "systemuser";
            linkEntity.LinkFromAttributeName = "systemuserid";
            linkEntity.LinkToAttributeName = "systemuserid";
            linkEntity.EntityAlias = "hs";
            linkEntity.Columns = new ColumnSet(new string[] { "isdisabled", "fullname" });
            linkEntity.LinkCriteria.AddCondition("isdisabled", ConditionOperator.Equal, false);

            linkEntityRoles.LinkEntities.Add(linkEntity);
            queryExpression.LinkEntities.Add(linkEntityRoles);

            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                
                int sNo = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string fullname = entity.Contains("hs.fullname") ? Convert.ToString((entity["hs.fullname"] as AliasedValue).Value) : string.Empty;
                    string teams = entity.Contains("name") ? Convert.ToString(entity["name"]) : string.Empty;
                    Console.WriteLine($"{sNo}Fullname :{fullname},Enable Users teams: {teams}");
                    sNo++;
                }
            }
        }

        private static void Accounts_ContainsPrimaryContactFetchXML(CrmServiceClient crmServiceClient)
        {
            string fetchxml = "<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>" +
                                  "<entity name='account'>" +
                                    "<attribute name='name' />" +
                                    "<attribute name='telephone1' />" +
                                    "<attribute name='websiteurl' />" +
                                    "<attribute name='tickersymbol' />" +
                                    "<attribute name='cdi_relationshiphealth' />" +
                                    "<attribute name='fax' />" +
                                    "<attribute name='cdi_clientidentifier' />" +
                                    "<attribute name='accountid' />" +
                                    "<attribute name='primarycontactid' />" +
                                    "<attribute name='emailaddress1' />" +
                                    "<order attribute='name' descending='true' />" +
                                    "<filter type='and'>" +
                                      "<condition attribute='primarycontactid' operator='not-null' />" +
                                    "</filter>" +
                                    "<link-entity name='contact' from='parentcustomerid' to='accountid' link-type='inner' alias='hs'>" +
                                      "<attribute name='emailaddress1' />" +
                                    "</link-entity>" +
                                  "</entity>" +
                                "</fetch>";
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchxml));
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNo = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string accName = entity.Contains("name") ? Convert.ToString(entity["name"]) : string.Empty;
                    string emailaddress1 = entity.Contains("hs.emailaddress1") ? Convert.ToString((entity["hs.emailaddress1"] as AliasedValue).Value) : string.Empty;
                    Console.WriteLine($"{sNo}Account Name: {accName}" + " , " + $"Primary Contact Email:{emailaddress1}");
                    sNo++;
                }
            }
        }

        private static void Accounts_ContainsPrimaryContact(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("account");
            queryExpression.ColumnSet.AddColumns(new string[] { "name", "primarycontactid" });
            queryExpression.AddOrder("name", OrderType.Descending);
            queryExpression.Criteria.AddCondition("primarycontactid", ConditionOperator.NotNull);

            LinkEntity linkEntity = new LinkEntity();
            linkEntity.LinkFromEntityName = "account";
            linkEntity.LinkToEntityName = "contact";
            linkEntity.LinkFromAttributeName = "accountid";
            linkEntity.LinkToAttributeName = "parentcustomerid";
            linkEntity.JoinOperator = JoinOperator.Inner;
            linkEntity.EntityAlias = "hs";
            linkEntity.Columns = new ColumnSet("emailaddress1");
            
            queryExpression.LinkEntities.Add(linkEntity);

            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNo = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string accountName = entity.Contains("name") ? Convert.ToString(entity["name"]) : string.Empty;
                    string emailAddress = entity.Contains("hs.emailaddress1") ? Convert.ToString((entity["hs.emailaddress1"] as AliasedValue).Value) : string.Empty;
                    Console.WriteLine($"{sNo}account Name: {accountName},Email Address: {emailAddress}");
                    sNo++;
                }
            }
        }
             
        private static void Contacts_ContainsCompanyFetchXML(CrmServiceClient crmServiceClient)
        {
            string fetchxml = "<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>" +
                              "<entity name='contact'>" +
                                "<attribute name='fullname' />" +
                                "<attribute name='telephone1' />" +
                                "<attribute name='contactid' />" +
                                "<attribute name='emailaddress1' />" +
                                "<order attribute='fullname' descending='false' />" +
                                "<filter type='and'>" +
                                  "<condition attribute='parentcustomerid' operator='not-null' />" +
                                "</filter>" +
                                "<link-entity name='account' from='accountid' to='parentcustomerid' visible='false' link-type='outer' alias='hs'>" +
                                  "<attribute name='name' />" +
                                "</link-entity>" +
                              "</entity>" +
                            "</fetch>";
            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchxml));
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNo = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string emailaddress1 = entity.Contains("emailaddress1") ? Convert.ToString(entity["emailaddress1"]) : string.Empty;
                    string accName = entity.Contains("hs.name") ? Convert.ToString((entity["hs.name"] as AliasedValue).Value) : string.Empty;
                    Console.WriteLine($"{sNo}Account Name: {accName}" + " , " + $"Contact Email:{emailaddress1}");
                    sNo++;
                }
            }
        }

        private static void Contacts_ContainsCompany(CrmServiceClient crmServiceClient)
        {
            QueryExpression queryExpression = new QueryExpression("contact");
            queryExpression.ColumnSet.AddColumns(new string[] { "fullname", "emailaddress1" });
            queryExpression.AddOrder("fullname", OrderType.Ascending);
            queryExpression.Criteria.AddCondition("parentcustomerid", ConditionOperator.NotNull);

            LinkEntity linkEntity = new LinkEntity();
            linkEntity.LinkFromEntityName = "contact";
            linkEntity.LinkToEntityName = "account";
            linkEntity.LinkFromAttributeName = "parentcustomerid";
            linkEntity.LinkToAttributeName = "accountid";
            linkEntity.JoinOperator = JoinOperator.LeftOuter;
            linkEntity.EntityAlias = "hs";
            linkEntity.Columns = new ColumnSet("name");

            queryExpression.LinkEntities.Add(linkEntity);

            EntityCollection entityCollection = crmServiceClient.RetrieveMultiple(queryExpression);
            if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
            {
                int sNo = 1;
                foreach (var entity in entityCollection.Entities)
                {
                    string emailaddress1 = entity.Contains("emailaddress1") ? Convert.ToString(entity["emailaddress1"]) : string.Empty;
                    string accName = entity.Contains("hs.name") ? Convert.ToString((entity["hs.name"] as AliasedValue).Value) : string.Empty;
                    Console.WriteLine($"{sNo}Account Name: {accName}" + " , " + $"Contact Email:{emailaddress1}");
                    sNo++;
                }
            }
        }
    }
}
