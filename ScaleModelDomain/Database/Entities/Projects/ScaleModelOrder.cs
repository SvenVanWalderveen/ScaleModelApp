using ScaleModelDomain.Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScaleModelDomain.Database.Entities.Projects
{
    internal class ScaleModelOrder : BaseDbDateTimeEntity
    {
        public Guid Id { get; set; }
        [Required]
        public String ShopName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ScaleModelOrderLine> ScaleModelOrderLines { get; set; }
    }
}
