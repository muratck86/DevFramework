using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.NHibernateUnitTests
{
    [TestClass]
    public class NhCategoryDalUnitTest
    {
        [TestMethod]
        public void GetList_returns_all_categories_without_filter()
        {
            NhCategoryDal nhCategoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = nhCategoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void GetList_returns_filtered_categories_with_filter()
        {
            NhCategoryDal nhCategoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = nhCategoryDal.GetList(p => p.CategoryName.Contains("con"));

            Assert.AreEqual(2, result.Count);
        }
    }
}
