namespace TrackDiary.Model.Common
{
    public interface IEntity<TEntityId>
    {
        TEntityId Id { get; set; }
    }
}
