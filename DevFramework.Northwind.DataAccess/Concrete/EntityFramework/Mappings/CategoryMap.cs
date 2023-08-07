using DevFramework.Northwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Category", "dbo").HasKey(e => e.CategoryId);
            Property(c => c.CategoryId).HasColumnName("CategoryID");
            Property(c => c.CategoryName).HasColumnName("CategoryName");
        }
    }
}
