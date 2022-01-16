using NUnit.Framework;
using TrackDiary.Model.Common;

namespace TrackDiary.Test.Infrastructure.Repositories.MembershipRepository
{
    public class StringIdentityTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckTypedEquals()
        {
            // typed equals
            StringIdentityType id1_1 = new StringIdentityType("1");
            StringIdentityType id1_2 = new StringIdentityType("1");
            StringIdentityType id2 = new StringIdentityType("2");

            Assert.IsTrue(id1_1.Equals(id1_2));
            Assert.IsFalse(id1_1.Equals(id2));
        }

        [Test]
        public void CheckStringEquals()
        {
            StringIdentityType id1_1 = new StringIdentityType("1");

            // compare to strings
            Assert.IsTrue(id1_1.Equals("1"));
            Assert.IsFalse(id1_1.Equals("2"));
        }

        [Test]
        public void CheckOperatorEquals()
        {
            StringIdentityType id1_1 = new StringIdentityType("1");
            StringIdentityType id1_2 = new StringIdentityType("1");
            StringIdentityType id2 = new StringIdentityType("2");

            // compare with == operator
            Assert.IsTrue(id1_1 == id1_2);
            Assert.IsFalse(id1_1 == id2);
        }

        [Test]
        public void CheckOperatorWithStringEquals()
        {
            StringIdentityType id1_1 = new StringIdentityType("1");

            // compare with == operator
            Assert.IsTrue(id1_1 == "1");
            Assert.IsFalse(id1_1 == "2");
        }
    }
}