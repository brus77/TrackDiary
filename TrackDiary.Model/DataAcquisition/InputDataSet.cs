using System;
using System.Collections.Generic;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class InputDataSet : IEntity<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }

        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }

        public IEnumerable<InputSource> Sources { get; set; }
    }
}
