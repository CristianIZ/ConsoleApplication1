using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Domain
{
    public class Files : KeyEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Extension { get; set; }
        public string Rename { get; set; }
    }
}
