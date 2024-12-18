using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Order : BaseEntity
    {
        public string ShippingAdress { get; set; }

        public int? AppUserId { get; set; }


        //Relational Properties

        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual AppUser AppUser { get; set; }

    }
}
