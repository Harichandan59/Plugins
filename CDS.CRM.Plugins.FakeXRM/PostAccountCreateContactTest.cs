using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using PluginPractice;

namespace CDS.CRM.Plugins.FakeXRM
{
    [TestClass]
    public class PostAccountCreateContactTest
    {
        [TestMethod]
        [Obsolete]
        public void TestMethod1()
        {
            var fakeContext = new XrmFakedContext();
            var service = fakeContext.GetOrganizationService();
            var entity = new Entity("account", Guid.NewGuid());
            entity.Attributes.Add("name", "Fake plugin");
            var inputParameter = new ParameterCollection();
            inputParameter.Add("Target", entity);

            var fakepluginContext = new XrmFakedPluginExecutionContext()
            {
                MessageName = "Create",
                Stage = 40,
                InputParameters = inputParameter
            };

            fakeContext.ExecutePluginWith<PostAccountCreateContact>(fakepluginContext);
        }

    }
}
