﻿using DevFramework.Core.Entities;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
    }
}
