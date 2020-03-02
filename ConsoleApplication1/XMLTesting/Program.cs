using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLLocalDatabase;
using XMLLocalDatabase.Entidades;
using XMLTesting.Helpers;

namespace XMLTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string
            var des4 = "asdqweee";
            var des5 = "rrrrrrr";
            var des6 = "ffffff";
            
            var lista = new List<string>() { };
            
            lista.Add(des4);
            lista.Add(des5);
            lista.Add(des6);
            #endregion
            
            var tarea = new Tarea()
            {
                Id = 1,
                Texto = lista,
                Titulo = "dsa"
            };
            
            var data = new XMLContext<Tarea>();
            
            data.Escribir(tarea, RutasHelper.RutaTareas());
            data.Leer(tarea, RutasHelper.RutaTareas());


            //var model = new SomeModel
            //{
            //    SomeString = new SomeInfo<string> { Value = "testData" },
            //    SomeInfo = new SomeInfo<int> { Value = 5 }
            //};
            //var serializer = new XmlSerializer(model.GetType());
            //serializer.Serialize(Console.Out, model);
            //
            //
            //var ser2 = new XmlSerializer(model.GetType());
            //ser2.Serialize(Console.Out, model);
            //Console.ReadKey();
        }


    }

    public class SomeIntInfo
    {
        [XmlAttribute]
        public int Value { get; set; }
    }

    public class SomeStringInfo
    {
        [XmlAttribute]
        public string Value { get; set; }
    }

    public class SomeInfo<T>
    {
        [XmlAttribute]
        public T Value { get; set; }
    }

    public class SomeModel
    {
        [XmlElement("SomeStringElementName")]
        public SomeInfo<string> SomeString { get; set; }

        [XmlElement("SomeInfoElementName")]
        public SomeInfo<int> SomeInfo { get; set; }
    }

}
