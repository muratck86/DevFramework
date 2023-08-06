using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    //Mapping is not necessary if table name is plural of entityname, and Property names are same as column names.
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", "dbo")
                .HasKey(e => e.ProductId);
            Property(e => e.ProductId).HasColumnName("ProductID");
            Property(e => e.CategoryId).HasColumnName("CategoryID");
            Property(e => e.UnitsInstock).HasColumnName("UnitsInstock");
            Property(e => e.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            Property(e => e.ProductName).HasColumnName("ProductName");
        }
    }
}
