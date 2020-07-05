namespace TrackDiary.Model.Common
{
    public interface IAggregateRoot<TEntityId> : IEntity<TEntityId> where TEntityId : IEntityIdentityType
    {

    }
}
