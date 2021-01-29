using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Dto
{
    public class FilesDto
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Extension { get; set; }
        public string Rename { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Rename))
                return $"NO GUARDADO - {Location}";
            else
                return $"Renombrado: {Rename} - {Location}";
        }
    }
}
