using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework__ORM_
{
    public class Genre : BaseEntity
    {
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
