using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EntityModels
{
    public class Supplier
    {
        public int SupplierId { get; set; } // Primary Key
        
        [Column("CompanyName", TypeName = "nvarchar(100)")]
        [Required] // Indicates the field is mandatory
        public string Name { get; set; } = string.Empty;

        [Column("Address", TypeName = "nvarchar(200)")]
        public string? Address { get; set; }

        [Column("Phone", TypeName = "varchar(15)")]
        public string? Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        = new HashSet<Product>();
    }
}
