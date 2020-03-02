using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLLocalDatabase.Entidades
{
    [Serializable]
    public class Tarea
    {
        [XmlAttribute(AttributeName ="Id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "Titulo")]
        public string Titulo { get; set; }

        [XmlElement( ElementName = "Descripcion")]
        public List<string> Texto { get; set; }

    }
}
