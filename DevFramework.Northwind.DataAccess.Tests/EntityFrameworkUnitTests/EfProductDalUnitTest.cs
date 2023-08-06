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
}
