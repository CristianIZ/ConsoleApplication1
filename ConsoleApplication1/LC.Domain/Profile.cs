using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Domain
{
    public class Profile : KeyEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Files> Files { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
