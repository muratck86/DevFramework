using DevFramework.Core.Entities;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Customer:IEntity
    {
        public virtual int CustomerId { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual string Phone { get; set; }
    }
}
