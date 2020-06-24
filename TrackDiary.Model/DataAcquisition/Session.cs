using System;
using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.InputDevices;

namespace TrackDiary.Model.DataAcquisition
{
    public class Session : IEntity<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }

        public Event Event { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public IEnumerable<DataPoint> DataPoints { get; set; }
        public IEnumerable<InputSource> InputSources { get; set; }
    }
}