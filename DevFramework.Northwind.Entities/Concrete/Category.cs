using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public int ReportsTo { get; set; }
    }

    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public  int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
    }
        
        
}
