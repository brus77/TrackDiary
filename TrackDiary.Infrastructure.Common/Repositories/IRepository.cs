using TrackDiary.Model.Common;
namespace TrackDiary.Infrastructure.Common.Repositories
{
    public interface IRepository<TAggregateRoot, TEntityId> where TAggregateRoot : IAggregateRoot<TEntityId>
    {

    }
}
