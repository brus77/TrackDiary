using System;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class DataPoint<TDataType> : IValueObject where TDataType : struct
    {
        public DateTimeOffset Time { get; set; }
        public TDataType? Value { get; set; }
    }
}
