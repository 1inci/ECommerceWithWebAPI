using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }     
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("OrderedProduct")]
        public int OrderedID { get; set; }
        public string OrderNumber { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public bool? FulFilled { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime BillDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual OrderedProduct OrderedProduct { get; set; }

    }
}
