using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class ProductAttribute : BaseEntity
    {
        public int ProductId { get; set; }

        public int EntityAttributeId { get; set; }


        //Relational Properties

        public virtual Product Product { get; set; }

        public virtual EntityAttribute EntityAttribute { get; set; }
    }
}
