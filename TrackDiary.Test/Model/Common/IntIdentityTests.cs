using NUnit.Framework;
using TrackDiary.Model.Common;

namespace TrackDiary.Test.Infrastructure.Repositories.MembershipRepository
{
    public class IntIdentityTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckTypedEquals()
        {
            // typed equals
            IntIdentityType id1_1 = new IntIdentityType(1);
            IntIdentityType id1_2 = new IntIdentityType(1);
            IntIdentityType id2 = new IntIdentityType(2);

            Assert.IsTrue(id1_1.Equals(id1_2));
            Assert.IsFalse(id1_1.Equals(id2));
        }

        [Test]
        public void CheckIntEquals()
        {
            IntIdentityType id1_1 = new IntIdentityType(1);

            // compare to strings
            Assert.IsTrue(id1_1.Equals(1));
            Assert.IsFalse(id1_1.Equals(2));
        }

        [Test]
        public void CheckOperatorEquals()
        {
            IntIdentityType id1_1 = new IntIdentityType(1);
            IntIdentityType id1_2 = new IntIdentityType(1);
            IntIdentityType id2 = new IntIdentityType(2);

            // compare with == operator
            Assert.IsTrue(id1_1 == id1_2);
            Assert.IsFalse(id1_1 == id2);
        }

        [Test]
        public void CheckOperatorWithStringEquals()
        {
            IntIdentityType id1_1 = new IntIdentityType(1);

            // compare with == operator
            Assert.IsTrue(id1_1 == 1);
            Assert.IsFalse(id1_1 == 2);
        }
    }
}