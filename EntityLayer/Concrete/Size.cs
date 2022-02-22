using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Size
    {
        [Key]
        public int SizeID { get; set; }
        public string SizeValue { get; set; }

        public virtual List<Product> Product { get; set; }

        public Size()
        {
            Product = new List<Product>();

        }
    }
}
