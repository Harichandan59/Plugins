// <copyright file="Common.cs" company="TECHXACT">
// Copyright (c) 2022 All Rights Reserved
// </copyright>
// <author></author>
// <date>20/10/2022 1:09:36 PM</date>
// <summary>Implements the common methods for Plugin.</summary>
namespace CDS.CRM.Common
{
    using System;
    using System.Globalization;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;

    /// <summary>
    /// It is used for common classes
    /// </summary>
    public class Common
    {
        /// <summary>
        /// It Creates the task 
        /// </summary>
        /// <param name="service">IOrganizationService Service</param>
        /// <param name="entity">Entity EntityArgs</param>
        public static void CreateTask(IOrganizationService service, Entity entity)
        {
            if (service != null && entity != null)
            {
                Entity task = new Entity("task");
                task["subject"] = "Sample task is created for test unit!";
                task["description"] = "Creating from test unit!";
                task["regardingobjectid"] = new EntityReference(entity.LogicalName, entity.Id);
                service.Create(task);
            }
        }

        /// <summary>
        /// Implements the Pre Operation Account Create Plugin.
        /// </summary>
        /// <param name="service">IOrganizationService service</param>
        /// <param name="entity">Entity entity</param>        
        public static void ContactExists(IOrganizationService service, Entity entity)
        {
            if (service != null && entity != null)
            {
                string firstname = entity.Attributes.Contains("firstname") ? Convert.ToString(entity.Attributes["firstname"], CultureInfo.InvariantCulture) : string.Empty;
                string lastname = entity.Attributes.Contains("lastname") ? Convert.ToString(entity.Attributes["lastname"], CultureInfo.InvariantCulture) : string.Empty;
                string emailaddress1 = entity.Attributes.Contains("emailaddress1") ? Convert.ToString(entity.Attributes["emailaddress1"], CultureInfo.InvariantCulture) : string.Empty;
                QueryExpression queryExpression = new QueryExpression("contact");
                queryExpression.Criteria.AddCondition("firstname", ConditionOperator.Equal, firstname);
                queryExpression.Criteria.AddCondition("lastname", ConditionOperator.Equal, lastname);
                queryExpression.Criteria.AddCondition("emailaddress1", ConditionOperator.Equal, emailaddress1);

                EntityCollection entityCollection = service.RetrieveMultiple(queryExpression);
                if (entityCollection != null && entityCollection.Entities != null && entityCollection.Entities.Count > 0)
                {
                    throw new InvalidPluginExecutionException($"Duplicate Records found with First name:{firstname},Last name:{lastname},Email Address:{emailaddress1}");
                }
            }
        }
    }
}