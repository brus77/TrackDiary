namespace TrackDiary.Model.Common
{
    public class StringIdentityType : IEntityIdentityType<string>
    {
        public string IdValue { get; set; }
    }
}
