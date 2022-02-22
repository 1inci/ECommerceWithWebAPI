using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class OrderedProduct
    {
        [Key]
        public int OrderedProductID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public int OrderProductNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? IsShipped { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Customer Customer { get; set; }
        public virtual List<OrderDetail> OrderDetail { get; set; }
        public OrderedProduct()
        {
            OrderDetail = new List<OrderDetail>();
        }
    }
}
