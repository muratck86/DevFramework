using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkUnitTests
{
    [TestClass]
    public class EfProductDalUnitTest
    {
        [TestMethod]
        public void GetList_returns_all_products_without_filter()
        {
            EfProductDal efProductDal = new EfProductDal();
            var result = efProductDal.GetList();

            Assert.AreEqual(78, result.Count);
        }

        [TestMethod]
        public void GetList_returns_filtered_products_with_filter()
        {
            EfProductDal efProductDal = new EfProductDal();
            var result = efProductDal.GetList(p => p.CategoryId==2);

            Assert.AreEqual(14, result.Count);
        }
    }

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
