namespace TrackDiary.Model.Common
{
    public interface IEntity<TEntityId> where TEntityId : IEntityIdentityType
    {
        TEntityId Id { get; set; }
    }
}
