using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.DataAcquisition;

namespace TrackDiary.Infrastructure.Repositories.DataAcquisition
{
    public class EventRepository : BaseRepository<Event, StringIdentityType>, IEventRepository
    {
    }
}
