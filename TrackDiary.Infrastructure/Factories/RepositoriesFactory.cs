using System;
using System.Collections.Concurrent;
using System.Linq;
using TrackDiary.Model.Common;

namespace TrackDiary.Infrastructure.Factories
{
    public static class RepositoriesFactory
    {
        private static readonly ConcurrentDictionary<Type, object> objCache = new ConcurrentDictionary<Type, object>();

        public static TRepository GetRepository<TRepository, TAggregateRoot, TEntityId>()
            where TAggregateRoot : IAggregateRoot<TEntityId>
            where TEntityId : IEntityIdentityType
            where TRepository : IRepository<TAggregateRoot, TEntityId>
        {
            return (TRepository)objCache.GetOrAdd(typeof(TRepository), _ => InstantiateRepository<TRepository, TAggregateRoot, TEntityId>());
        }

        private static TRepository InstantiateRepository<TRepository, TAggregateRoot, TEntityId>()
            where TAggregateRoot : IAggregateRoot<TEntityId>
            where TEntityId : IEntityIdentityType
            where TRepository : IRepository<TAggregateRoot, TEntityId>
        {
            var repoConcreteTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(TRepository)) && t.GetConstructor(Type.EmptyTypes) != null));
            if (!repoConcreteTypes.Any())
            {
                throw new Exception($"No implementations for type {typeof(TRepository).Name}");
            }
            if (repoConcreteTypes.Count() > 1)
            {
                throw new Exception($"Multiple implementations for type {typeof(TRepository).Name}");
            }
            return (TRepository)Activator.CreateInstance(repoConcreteTypes.Single());
        }
    }
}
