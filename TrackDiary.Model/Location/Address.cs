using TrackDiary.Model.Common;

namespace TrackDiary.Model.Location
{
    public class Address : IValueType
    {
        public Address(string state, string city, string streetAddress)
        {
            State = state;
            City = city;
            StreetAddress = streetAddress;
        }

        public string State { get; private set; }
        public string City { get; private set; }
        public string StreetAddress { get; private set; }
    }
}
