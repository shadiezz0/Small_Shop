using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.Items
{
    [Table("Itm_Catogory")]
    public class Catogory
    {
        [Key]
        public int Catogry_Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}
