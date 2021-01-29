using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Dto
{
    public class ProfileDto
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<FilesDto> Files { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
