using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.DataAcquisition;

namespace TrackDiary.Infrastructure.Repositories.DataAcquisition
{
    public class EventRepository : IEventRepository
    {
        public Event this[IntIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Event CreateNew()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Event> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
