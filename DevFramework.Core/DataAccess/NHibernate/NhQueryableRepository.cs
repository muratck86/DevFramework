using DevFramework.Core.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private IQueryable<T> _entities;
        private NHibernateHelper _helper;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }

        public virtual IQueryable<T> Entities => _entities ?? _helper.OpenSession().Query<T>();


        public IQueryable<T> Table => this.Entities;
    }
}
