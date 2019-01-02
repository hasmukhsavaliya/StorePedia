using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.RepositoryProvider
{
    internal class Factory
    {
        private readonly IDictionary<Type, Func<DataBaseContext, object>> _factoryCache;

        public Factory()
        {
            _factoryCache = GetFactories();
        }

        public Func<DataBaseContext, object> GetRepositoryFactoryForEntityType<T>()
            where T : class
        {
            Func<DataBaseContext, object> factory = GetRepositoryFactoryFromCache<T>();
            if (factory != null)
            {
                return factory;
            }

            return DefaultEntityRepositoryFactory<T>();
        }

        public Func<DataBaseContext, object> GetRepositoryFactoryFromCache<T>()
        {
            Func<DataBaseContext, object> factory;
            _factoryCache.TryGetValue(typeof(T), out factory);
            return factory;
        }

        private IDictionary<Type, Func<DataBaseContext, object>> GetFactories()
        {
            Dictionary<Type, Func<DataBaseContext, object>> dic = new Dictionary<Type, Func<DataBaseContext, object>>();
            dic.Add(typeof(IMembershipRepository), context => new MembershipRepositoryImpl(context));
            //Add Extended and Custom Repositories here
            return dic;
        }

        private Func<DataBaseContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new RepositoryBaseImpl<T>(dbContext);
        }
    }
}
