using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.DataAcquisition;

namespace TrackDiary.Infrastructure.Repositories.DataAcquisition
{
    public class InputSourceRepository : IInputSourceRepository
    {
        public InputSource this[IntIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public InputSource CreateNew()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<InputSource> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
