using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }    
        
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public int UnitPrice { get; set; }

        [ForeignKey("Size")]
        public int SizeID { get; set; }

        public string Picture { get; set; }

        public bool? StockAvailable { get; set; }

        public virtual Category Category { get; set; }

        public virtual Size Size { get; set; }

        public virtual List<OrderDetail> OrderDetail { get; set; }



    }
}
