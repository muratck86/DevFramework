using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkUnitTests
{
    [TestClass]
    public class EfCategoryDalUnitTest
    {
        [TestMethod]
        public void GetList_returns_all_categories_without_filter()
        {
            EfCategoryDal efCategoryDal = new EfCategoryDal();
            var result = efCategoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void GetList_returns_filtered_categories_with_filter()
        {
            EfCategoryDal efCategoryDal = new EfCategoryDal();
            var result = efCategoryDal.GetList(p => p.CategoryName.Contains("con"));

            Assert.AreEqual(2, result.Count);
        }
    }
}
