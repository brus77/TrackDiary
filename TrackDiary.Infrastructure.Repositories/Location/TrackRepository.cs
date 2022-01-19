using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.Location;

namespace TrackDiary.Infrastructure.Repositories.Location
{
    public class TrackRepository : BaseRepository<Track, StringIdentityType>, ITrackRepository
    {
    }
}
