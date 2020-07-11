using System;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public interface IInputSourceRepository : IRepository<InputSource, IntIdentityType>
    {
    }
}
