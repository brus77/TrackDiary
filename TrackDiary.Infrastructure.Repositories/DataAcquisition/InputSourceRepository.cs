using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.DataAcquisition;

namespace TrackDiary.Infrastructure.Repositories.DataAcquisition
{
    public class InputSourceRepository :  BaseRepository<InputSource, StringIdentityType>, IInputSourceRepository
    {
    }
}
