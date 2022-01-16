using System;
using System.Diagnostics.CodeAnalysis;

namespace TrackDiary.Model.Common
{
    public abstract class IEntityIdentityType
    {
        public override abstract bool Equals(object obj);
        public override abstract int GetHashCode();
        public override abstract string ToString();
    }

    public abstract class IEntityIdentityType<TIdentityType> : IEntityIdentityType, IEquatable<TIdentityType>
    {
        public virtual TIdentityType IdValue { get; protected set; }

        public virtual bool Equals([AllowNull] TIdentityType other)
        {
            return this.Equals((object)other);
        }
    }
}
