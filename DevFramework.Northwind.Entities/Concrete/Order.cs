using DevFramework.Core.Entities;
using System;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Order : IEntity
    {
        public virtual int OrderId { get; set; }
        public virtual string CustomerId { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual DateTime OrderDate { get; set; }
    }
        
        
}
