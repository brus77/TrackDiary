using System;
using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class DataPoint<TDataType> : IDataPoint, IValueObject where TDataType : struct
    {
        private TDataType _internalValue;

        public DateTimeOffset Time { get; set; }
        public object Value { get => _internalValue; set => _internalValue = (TDataType) value; }
    }
}
