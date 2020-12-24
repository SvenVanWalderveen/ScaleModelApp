using ScaleModelDomain.Database.Entities.Projects;
using ScaleModelDomain.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScaleModelDomain.Converters
{
    public static class InputFieldConfigurationConverter
    {
        internal static InputFieldConfiguration ConvertToEntity(this InputFieldConfigurationDataModel model)
        {
            return new InputFieldConfiguration()
            {
                Id = model.Id,
                ControlType = model.ControlType,
                DataType = model.DataType,
                IsRequired = model.IsRequired,
                LabelName = model.LabelName,
                MaxLength = model.MaxLength,
                ToolTip = model.ToolTip,
                ValidationRule = model.ValidationRule
            };
        }
        internal static void UpdateFromModel(this InputFieldConfiguration entity, InputFieldConfigurationDataModel model)
        {
            entity.Id = model.Id;
            entity.ControlType = model.ControlType;
            entity.DataType = model.DataType;
            entity.IsRequired = model.IsRequired;
            entity.LabelName = model.LabelName;
            entity.MaxLength = model.MaxLength;
            entity.ToolTip = model.ToolTip;
            entity.ValidationRule = model.ValidationRule;
        }

        internal static InputFieldConfigurationDataModel ConvertToDataModel(this InputFieldConfiguration entity)
        {
            return new InputFieldConfigurationDataModel()
            {
                Id = entity.Id,
                ControlType = entity.ControlType,
                DataType = entity.DataType,
                IsRequired = entity.IsRequired,
                LabelName = entity.LabelName,
                MaxLength = entity.MaxLength,
                ToolTip = entity.ToolTip,
                ValidationRule = entity.ValidationRule
            };
        }

        internal static List<InputFieldConfigurationDataModel> ConvertToDataModels(this List<InputFieldConfiguration> entities)
        {
            return entities.Select(x => new InputFieldConfigurationDataModel()
            {
                Id = x.Id,
                ControlType = x.ControlType,
                DataType = x.DataType,
                IsRequired = x.IsRequired,
                LabelName = x.LabelName,
                MaxLength = x.MaxLength,
                ToolTip = x.ToolTip,
                ValidationRule = x.ValidationRule
            }).ToList();
        }
    }
}
