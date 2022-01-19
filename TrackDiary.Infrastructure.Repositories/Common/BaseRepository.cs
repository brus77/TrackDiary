using LiteDB;
using System;
using System.Collections.Generic;
using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    public class BaseRepository<EntityType, EntityIdentityType> : IRepository<EntityType, EntityIdentityType> where EntityIdentityType : IEntityIdentityType, new() where EntityType : IAggregateRoot<EntityIdentityType>, new()
    {
        protected LiteDatabase dbInstance => LiteDBContext.Instance();
        protected ILiteCollection<EntityType> Collection => dbInstance.GetCollection<EntityType>();

        public virtual EntityType this[EntityIdentityType id] {
            get {
                return Collection.Query().Where(x => x.Id == id).SingleOrDefault();
            }

            set {
                if (! id.Equals(value.Id))
                {
                    throw new ArgumentException("Entity's Id must be equal to parameter passed to indexer", nameof(id));
                }

                var usr = Collection.Query().Where(x => x.Id == id).SingleOrDefault();
                if (usr == null)
                {
                    throw new ArgumentException($"Entity with id { id } not found in repository { nameof(UserRepository) }", nameof(id));
                }
                
                Collection.Update(value);
                dbInstance.Checkpoint();
            }
        }

        public virtual EntityType CreateNew()
        {
            var newItem = new EntityType();
            newItem.Id = new EntityIdentityType();
            Collection.Insert(newItem);
            dbInstance.Checkpoint();
            return newItem;
        }

        public virtual bool Delete(EntityIdentityType id)
        {
            var doc = Collection.Query().Where(x => x.Id == id).Single();
            bool deleted = Collection.Delete(new BsonValue(doc.Id.ToString()));
            dbInstance.Checkpoint();
            return deleted;
        }

        public virtual IEnumerable<EntityType> GetAll()
        {
            return Collection.Query().ToEnumerable();
        }
    }
}
