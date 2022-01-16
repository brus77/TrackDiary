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

            if (!(obj is IEntityIdentityType<int>))
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
                return IdValue == ((IEntityIdentityType<int>)obj).IdValue;
            }
        }

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
