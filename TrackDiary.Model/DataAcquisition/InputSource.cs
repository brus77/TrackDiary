using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.InputDevices;

namespace TrackDiary.Model.DataAcquisition
{
    public class InputSource : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }

        public string Name { get; set; }
        public Sensor Sensor { get; set; }
        public IEnumerable<IDataPoint> Data { get; set; }
    }
}