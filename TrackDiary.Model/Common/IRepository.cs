using System.Collections.Generic;

namespace TrackDiary.Model.Common
{
    public interface IRepository<TAggregateRoot, TEntityId> where TAggregateRoot : IAggregateRoot<TEntityId>
                                                            where TEntityId : IEntityIdentityType
    {
        IEnumerable<TAggregateRoot> GetAll();
        TAggregateRoot this[TEntityId id] { get; set; }
    }
}
