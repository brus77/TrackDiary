using System;
using System.Collections.Generic;
using System.Linq;
using TrackDiary.Model.Common;

namespace TrackDiary.Infrastructure.Factories
{
    public static class RepositoriesFactory
    {
        private static IDictionary<Type, object> objCache;

        static RepositoriesFactory()
        {
            objCache = new Dictionary<Type, object>();
        }
        
        public static TRepository GetRepository<TRepository, TAggregateRoot, TEntityId>() where TAggregateRoot : IAggregateRoot<TEntityId>
                                                            where TEntityId : IEntityIdentityType where TRepository : IRepository<TAggregateRoot, TEntityId>
        {
            if (objCache.ContainsKey(typeof(TRepository)))
            {
                return (TRepository) objCache[typeof(TRepository)];
            } else
            {
                lock(objCache)
                {
                    if (objCache.ContainsKey(typeof(TRepository)))
                    {
                        return (TRepository) objCache[typeof(TRepository)];
                    } else
                    {
                        var newRepo = InstantiateRepository<TRepository, TAggregateRoot, TEntityId>();
                        objCache.Add(typeof(TRepository), newRepo);
                        return newRepo;
                    }
                }
            }
        }

        private static TRepository InstantiateRepository<TRepository, TAggregateRoot, TEntityId>() where TAggregateRoot : IAggregateRoot<TEntityId>
                                                            where TEntityId : IEntityIdentityType where TRepository : IRepository<TAggregateRoot, TEntityId>
        {
            var repoConcreteTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(TRepository)) && t.GetConstructor(Type.EmptyTypes) != null));
            if (repoConcreteTypes.Count() == 0)
            {
                throw new Exception($"No implementations for type {typeof(TRepository).Name}");
            }
            if (repoConcreteTypes.Count() > 1)
            {
                throw new Exception($"Multiple implementations for type {typeof(TRepository).Name}");
            }

            return (TRepository) Activator.CreateInstance(repoConcreteTypes.Single());
        }
    }
}
