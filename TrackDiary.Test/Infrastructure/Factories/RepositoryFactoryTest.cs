using NUnit.Framework;
using TrackDiary.Infrastructure.Factories;
using TrackDiary.Infrastructure.Repositories.InputDevices;
using TrackDiary.Model.Common;
using TrackDiary.Model.InputDevices;

namespace TrackDiary.Test.Infrastructure.Factories
{
    public class RepositoryFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSensorRepositoryInstance()
        {
            var repo = RepositoriesFactory.GetRepository<ISensorRepository, Sensor, StringIdentityType>();
            Assert.IsTrue(repo is SensorRepository);
        }

        [Test]
        public void TestSingletorRepositoryImplementation()
        {
            var repo1 = RepositoriesFactory.GetRepository<ISensorRepository, Sensor, StringIdentityType>();
            var repo2= RepositoriesFactory.GetRepository<ISensorRepository, Sensor, StringIdentityType>();
            Assert.IsTrue(object.ReferenceEquals(repo1, repo2));
        }
    }
}
