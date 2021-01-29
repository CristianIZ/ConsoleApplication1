using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC.Domain;

namespace LC.Repositories.Implementations
{
    public class FileRepository : BaseRepository
    {
        public Files GetByKey(Guid key)
        {
            return dbContext.Files
                .Where(p => p.Key == key).FirstOrDefault();
        }

        public void Delete(Guid key)
        {
            var file = GetByKey(key);
            // dbContext.Set<Files>().Remove(file);
            dbContext.Entry<Files>(file).State = EntityState.Deleted;
        }
    }
}
