using System;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public interface IEventRepository : IRepository<Event, IntIdentityType>
    {
    }
}
