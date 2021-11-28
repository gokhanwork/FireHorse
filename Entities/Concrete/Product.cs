using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int UnitId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public decimal Quantity { get; set; }
        public int AletQuantity { get; set; }

        public Unit Unit { get; set; }
        public Category Category { get; set; }
    }
}
