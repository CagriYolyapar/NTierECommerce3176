using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public int? MainCategoryId { get; set; }


        //Relational Properties

        public virtual Category MainCategory { get; set; }

        public virtual List<Category> Categories { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
