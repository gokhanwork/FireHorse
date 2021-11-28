using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Unit : IEntity
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Product Product { get; set; }
    }
}
