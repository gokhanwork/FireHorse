using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Table : IEntity
    {
        public Guid TableId { get; set; }
        public string TableName { get; set; }
        public bool TableStatus { get; set; }


    }
}
