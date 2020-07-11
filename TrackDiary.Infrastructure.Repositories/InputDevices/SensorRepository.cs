using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.InputDevices;

namespace TrackDiary.Infrastructure.Repositories.InputDevices
{
    public class SensorRepository : ISensorRepository
    {
        public Sensor this[IntIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IEnumerable<Sensor> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
