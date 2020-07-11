using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.Location;

namespace TrackDiary.Infrastructure.Repositories.Location
{
    public class TrackRepository : ITrackRepository
    {
        public Track this[StringIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IEnumerable<Track> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
