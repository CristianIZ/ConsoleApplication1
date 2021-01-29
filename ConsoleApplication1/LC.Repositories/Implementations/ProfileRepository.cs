using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC.Context;
using LC.Domain;

namespace LC.Repositories.Implementations
{
    public class ProfileRepository : BaseRepository
    {
        public FileRepository fileRepository { get; set; }
        public ProfileRepository()
        {
            this.fileRepository = new FileRepository();
        }

        public IEnumerable<Profile> GetAll()
        {
            this.dbContext = new LcContext();

            var profiles = dbContext.Profiles
                           .Include(p => p.Files)
                           .ToList();
            return profiles;
        }

        public Profile GetByKey(Guid key)
        {
            return dbContext.Profiles
                .Include(p => p.Files)
                .Where(p => p.Key == key).FirstOrDefault();
        }

        public Files GetFileByKey(Guid key)
        {
            return dbContext.Files
                .Where(p => p.Key == key).FirstOrDefault();
        }

        public Profile Add(Profile profile)
        {
            return dbContext.Profiles.Add(profile);
        }

        public Profile Update(Profile profile)
        {
            var entity = GetByKey(profile.Key);

            entity.Name = profile.Name;
            entity.Description = profile.Description;
            entity.Files = new List<Files>();

            foreach (var file in profile.Files)
            {
                var fileEntity = GetFileByKey(file.Key);

                if (fileEntity == null)
                {
                    entity.Files.Add(file);
                }
                else
                {
                    entity.Files.Add(fileEntity);
                }
            }

            return entity;
        }

        public void Delete(Profile profile)
        {
            var entity = GetByKey(profile.Key);
            dbContext.Profiles.Remove(entity);
        }
    }
}
