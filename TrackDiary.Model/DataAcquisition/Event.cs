using System;
using System.Collections.Generic;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class Event : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }

        public string Name { get; set; }
        public DateTimeOffset FirstDayOfEvent { get; set; }
        public IEnumerable<Session> Sessions { get; }
    }
}