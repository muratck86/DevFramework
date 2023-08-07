using DevFramework.Core.Entities;
using System;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Employee : IEntity
    {
        public virtual int EmployeeId { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual int ReportsTo { get; set; }
    }
        
        
}
