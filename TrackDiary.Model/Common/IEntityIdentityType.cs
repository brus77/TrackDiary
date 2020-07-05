namespace TrackDiary.Model.Common
{
    public interface IEntityIdentityType
    {
    }

    public interface IEntityIdentityType<TIdentityType> : IEntityIdentityType
    {
        TIdentityType IdValue { get; set; }
    }
}
