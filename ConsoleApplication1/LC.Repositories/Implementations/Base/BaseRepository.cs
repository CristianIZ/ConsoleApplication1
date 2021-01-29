using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC.Context;

namespace LC.Repositories.Implementations
{
    public class BaseRepository
    {
        protected LcContext dbContext = new LcContext();

        public void Complete()
        {
            dbContext.SaveChanges();
        }
    }
}
