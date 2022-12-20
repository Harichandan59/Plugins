using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
namespace CRMSDKPractice.Settlement
{
    public class PostOpertaion_OnCreate_Settlement_Create_SettlementParty : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the Tracing service from the service provider.
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            // Obtain service factory from the service provider.
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            Entity entity = (Entity)context.InputParameters["Target"];
            // Obtain the organization service.
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                tracingService.Trace($"Post settlement record create plugin execution started :{DateTime.Now}");
                if (entity.LogicalName == "cdi_settlement")
                {
                    Create_SettlementParty(service, entity);
                }
                tracingService.Trace($"Post settlement record create plugin execution started :{DateTime.Now}");
            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
        }
        private void Create_SettlementParty(IOrganizationService service, Entity entity)
        {
            var name = entity.Attributes.Contains("cdi_name") ? Convert.ToString(entity.Attributes["cdi_name"]) : string.Empty;
            var roletype = entity.Attributes.Contains("cdi_roletype") ? (OptionSetValue)entity["cdi_roletype"] : null;
            if (roletype != null)
            {
                Entity settlementparty = new Entity("cdi_settlementparty");
                settlementparty["cdi_name"] = name;
                settlementparty["cdi_roletype"] = roletype;
                settlementparty["cdi_datesigned"] = DateTime.Now;
                //settlementparty["cdi_emailaddress"] = "Hari@59.com";
                service.Create(settlementparty);
            }
        }
    }
}
