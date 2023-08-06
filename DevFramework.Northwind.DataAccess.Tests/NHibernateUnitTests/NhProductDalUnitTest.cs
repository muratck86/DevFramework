using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.Northwind.DataAccess.Tests.NHibernateUnitTests
{
    [TestClass]
    public class NhProductDalUnitTest
    {
        [TestMethod]
        public void GetList_returns_all_products_without_filter()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList();

            Assert.AreEqual(78, result.Count);
        }

        [TestMethod]
        public void GetList_returns_filtered_products_with_filter()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList(p => p.CategoryId == 2);

            Assert.AreEqual(14, result.Count);
        }
    }
}
