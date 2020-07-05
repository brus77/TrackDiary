using System;
namespace TrackDiary.Model.DataAcquisition
{
    public interface IDataPoint
    {
        public DateTimeOffset Time { get; set; }
        public object Value { get; set; }
    }
}
