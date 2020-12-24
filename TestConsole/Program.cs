using ScaleModelDomain;
using ScaleModelDomain.DataModels;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaleModelDomainAdapter.OnStartup();

            //ScaleModelDomain.ScaleModelDomainAdapter.CreateInputFieldConfiguration(new InputFieldConfigurationDataModel()
            //{
            //    ControlType = ScaleModelDomain.Base.Enums.ControlType.TextBox,
            //    DataType = System.ComponentModel.DataAnnotations.DataType.Text,
            //    IsRequired = false,
            //    LabelName = "Naam",
            //    MaxLength = 255,
            //});       
            var result = ScaleModelDomainAdapter.GetInputConfigurationDataModel(Guid.Parse("C4DCE4E1-FA24-4D29-B91D-91B2674EF4DC"));
            ScaleModelDomainAdapter.DeleteInputFieldConfiguration(result.DataResult);

        
        }
    }
}
