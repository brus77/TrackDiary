namespace TrackDiary.Model.Common
{
    public class IntIdentityType : IEntityIdentityType<int>
    {
        public override int IdValue { get; protected set; }

        public IntIdentityType(int idValue)
        {
            this.IdValue = idValue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (object.ReferenceEquals(this, obj)) return true;

            if (!(obj is IntIdentityType))
            {
                if (obj is int)
                {
                    return IdValue == (int) obj;
                } else
                {
                    return false;
                }
            } else
            {
                return IdValue == ((IntIdentityType)obj).IdValue;
            }
        }

        public static bool operator ==(IntIdentityType lhs, IntIdentityType rhs)
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

        public static bool operator !=(IntIdentityType lhs, IntIdentityType rhs) => !(lhs == rhs);

        public static implicit operator IntIdentityType(int idValue) => new IntIdentityType(idValue);

        public override int GetHashCode()
        {
            return IdValue.GetHashCode();
        }

        public override string ToString()
        {
            return IdValue.ToString();
        }
    }
}
