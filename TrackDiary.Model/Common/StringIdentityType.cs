﻿using System;

namespace TrackDiary.Model.Common
{
    public class StringIdentityType : IEntityIdentityType<string>
    {
        public StringIdentityType(string idValue)
        {
            if (string.IsNullOrEmpty(idValue))
            {
                throw new ArgumentNullException(nameof(idValue));
            }

            this.IdValue = idValue;
        }

        public override string IdValue { get; protected set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (object.ReferenceEquals(this, obj)) return true;

            if (!(obj is IEntityIdentityType<string>))
            {
                if (obj is string)
                {
                    return string.Equals(IdValue, obj as string, System.StringComparison.OrdinalIgnoreCase);
                } else
                {
                    return false;
                }
            } else
            {
                return string.Equals(IdValue, (obj as IEntityIdentityType<string>).IdValue, System.StringComparison.OrdinalIgnoreCase);
            }
        }

        public static bool operator ==(StringIdentityType lhs, StringIdentityType rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(StringIdentityType lhs, StringIdentityType rhs) => !(lhs == rhs);

        public override int GetHashCode()
        {
            return IdValue.GetHashCode();
        }

        public override string ToString()
        {
            return IdValue;
        }
    }
}
