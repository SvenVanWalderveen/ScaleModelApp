using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScaleModelDomain;
using ScaleModelDomain.DataModels;

namespace UnitTests
{
    [TestClass]
    public class AdapterUnitTests
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            ScaleModelDomainAdapter.OnStartup();
        }
        [TestMethod]
        public void Test001()
        {
            var result = ScaleModelDomainAdapter.AddDataModelToDb(new InputFieldConfigurationDataModel()
            {
                ControlType = ScaleModelDomain.Base.Enums.ControlType.TextBox,
                DataType = System.ComponentModel.DataAnnotations.DataType.Text,
                IsRequired = true,
                LabelName = "Test-field",
                ToolTip = "Test-field tooltip"
            });
            Assert.IsTrue(result.CallSuccessfull);
        }
        [TestMethod]
        public void Test002()
        {
            var dataModel = (InputFieldConfigurationDataModel) ScaleModelDomainAdapter.GetLatestDataModel(typeof(InputFieldConfigurationDataModel)).DataResult;
            dataModel.MaxLength = 255;
            var result = ScaleModelDomainAdapter.UpdateDataModel(dataModel);
            Assert.IsTrue(result.CallSuccessfull);
        }
        [TestMethod]
        public void Test003()
        {
            var dataModel = (InputFieldConfigurationDataModel)ScaleModelDomainAdapter.GetLatestDataModel(typeof(InputFieldConfigurationDataModel)).DataResult;
            var result = ScaleModelDomainAdapter.DeleteDataModelFromDb(dataModel);
            Assert.IsTrue(result.CallSuccessfull);
        }
        [TestMethod]
        public void Test004()
        {
            var result = ScaleModelDomainAdapter.AddDataModelToDb(null);
            Assert.IsFalse(result.CallSuccessfull);
        }
    }
}
