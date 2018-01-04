using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public  class Factory
    {
        [Key]
        [MaxLength(50)]
        public string FactoryName { get; set; }

        public decimal Discount { get; set; }

        public string Remark { get; set; }
    }
}
