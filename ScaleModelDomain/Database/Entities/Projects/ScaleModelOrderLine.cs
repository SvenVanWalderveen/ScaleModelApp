using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelOrderLine : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        public Guid? ScaleModelProjectId { get; set; }
        public ScaleModelProject ScaleModelProject { get; set; }
        public Guid ScaleModelOrderId { get; set; }
        public ScaleModelOrder ScaleModelOrder { get; set; }
        public string Productcode { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double PricePerUnit { get; set; }
    }
}
