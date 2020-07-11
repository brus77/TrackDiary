using TrackDiary.Model.Common;

namespace TrackDiary.Model.Location
{
    public interface ITrackRepository : IRepository<Track, StringIdentityType>
    {
    }
}
