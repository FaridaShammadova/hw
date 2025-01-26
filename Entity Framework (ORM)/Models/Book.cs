using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework__ORM_
{
    public class Book : BaseEntity
    {
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {SalePrice} - {CostPrice}";
        }
    }
}
