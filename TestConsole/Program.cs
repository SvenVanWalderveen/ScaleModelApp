using ScaleModelDomain;
using ScaleModelDomain.DataModels;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {
            ScaleModelDomainAdapter.OnStartup();

            //var result = ScaleModelDomainAdapter.AddDataModelToDb(new InputFieldConfigurationDataModel()
            //{
            //    ControlType = ScaleModelDomain.Base.Enums.ControlType.TextBox,
            //    DataType = System.ComponentModel.DataAnnotations.DataType.Text,
            //    IsRequired = true,
            //    LabelName = "Projectduur1",
            //    MaxLength = 255,
            //    ToolTip = "Projectduur in uren"
            //});
            //if (result.StatusCode == ResponseEnvelopeStatusCode.Succeeded)
            //{
            //    Console.WriteLine("Model successfully inserted");
            //    var dataModel = (InputFieldConfigurationDataModel)ScaleModelDomainAdapter.GetLatestDataModel(typeof(InputFieldConfigurationDataModel)).DataResult;
            //    dataModel.ToolTip = "Hello";
            //    var result1 = ScaleModelDomainAdapter.UpdateDataModel(dataModel);
            //    if (result1.StatusCode == ResponseEnvelopeStatusCode.Succeeded)
            //    {
            //        Console.WriteLine("Model successfully updated");
            //        ScaleModelDomainAdapter.DeleteDataModelFromDb(dataModel);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error during inserting model");
            //    Console.WriteLine(result.Exception);
            //}
            var dataModel = ScaleModelDomainAdapter.GetDataModels(typeof(InputFieldConfigurationDataModel));
            Console.ReadLine();



            //var result = ScaleModelDomainAdapter.GetIdOfScaleModelProjectType("Vrachtwagen");
            //ScaleModelDomainAdapter.CreateScaleModelProjectType(new ScaleModelProjectTypeDataModel()
            //{
            //    TypeName = "Vrachtwagen"
            //});
            //ScaleModelDomain.ScaleModelDomainAdapter.CreateInputFieldConfiguration(new InputFieldConfigurationDataModel()
            //{
            //    ControlType = ScaleModelDomain.Base.Enums.ControlType.TextBox,
            //    DataType = System.ComponentModel.DataAnnotations.DataType.Text,
            //    IsRequired = false,
            //    LabelName = "Naam",
            //    MaxLength = 255,
            //});       
            //var result = ScaleModelDomainAdapter.GetInputConfigurationDataModel(Guid.Parse("C4DCE4E1-FA24-4D29-B91D-91B2674EF4DC"));
            //ScaleModelDomainAdapter.DeleteInputFieldConfiguration(result.DataResult);

        
        }
    }
}
