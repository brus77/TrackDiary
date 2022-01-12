using Moq;
using NUnit.Framework;
using System.Linq;
using TrackDiary.Infrastructure.Repositories.Membership;
using TrackDiary.Model.Membership;

namespace TrackDiary.Test
{
    public class Tests
    {
        private MockRepository _mocks;
        

        [SetUp]
        public void Setup()
        {
            _mocks = new MockRepository(MockBehavior.Loose);
            Mock<IUserRepository> userRepository = _mocks.Create<IUserRepository>();
        }

        [Test]
        public void GetAllUsers()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var all = repo.GetAll();
            Assert.IsNotNull(all.SingleOrDefault(x => x.Id == newItemId));
        }

        [Test]
        public void AndAndFindSingleUser()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var _ = repo[newItemId];
            Assert.Pass();
        }
    }
}