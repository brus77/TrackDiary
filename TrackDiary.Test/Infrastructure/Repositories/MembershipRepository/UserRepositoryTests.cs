using NUnit.Framework;
using System.Linq;
using TrackDiary.Infrastructure.Repositories.Common;

namespace TrackDiary.Test.Infrastructure.Repositories.MembershipRepository
{
    public class UserRepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllUsers()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var all = repo.GetAll();
            Assert.IsNotNull(all.SingleOrDefault(x => x.Id == newItemId));
            repo.Delete(newItemId);
        }

        [Test]
        public void CreateAndFindSingleUser()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var usr = repo[newItemId];
            Assert.NotNull(usr);
            repo.Delete(usr.Id);
        }

        [Test]
        public void CreateAndDeleteSingleUser()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var usr = repo[newItemId];
            Assert.IsNotNull(usr);
            repo.Delete(usr.Id);
            usr = repo[newItemId];
            Assert.IsNull(usr);
        }

        [Test]
        public void UpdateUser()
        {
            var repo = new UserRepository();
            var newItem = repo.CreateNew();
            var newItemId = newItem.Id;
            var usr = repo[newItemId];
            usr.UserName = "test1";
            repo[newItemId] = usr;
            var usrModified = repo[newItemId];
            Assert.AreEqual(usrModified.UserName, "test1");

            usrModified.UserName = "test2";
            repo[newItemId] = usrModified;
            var usrModified2 = repo[newItemId];
            Assert.AreEqual(usrModified2.UserName, "test2");
            var deleted = repo.Delete(newItemId);
            Assert.IsTrue(deleted);
        }
    }
}