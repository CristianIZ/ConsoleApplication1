using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using XMLLocalDatabase.Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;

namespace XMLLocalDatabase
{
    public class XMLContext<T>
    {
        /// <summary>
        /// Dado un objeto (serializable), lo serializa y devuelve un string
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private string SerializarEntidad(T entity)
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(entity.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, entity, emptyNamepsaces);
                    return stream.ToString();
                }
            }
        }

        /// <summary>
        /// Serializa la entidad y la escribe en un archivo espeficado en la ruta (si no existe lo crea)
        /// La escritura se realiza al final del archivo
        /// </summary>
        /// <param name="entity">Entidad a ser serializada</param>
        /// <param name="rutaEscritura">Ruta del archivo donde se escribira el xml</param>
        /// <returns></returns>
        public bool Escribir(T entity, string rutaEscritura)
        {
            var rutaBackup = GenerarRutaBackup(rutaEscritura);

            //Si el archivo ya existe omite la declaracion
            if (!File.Exists(rutaEscritura))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                using (var sw = new StreamWriter(rutaEscritura))
                {
                    sw.WriteLine(xmlDeclaration.OuterXml);
                    sw.WriteLine("<" + entity.GetType().Name + "s>");
                    sw.WriteLine("</" + entity.GetType().Name + "s>");
                }
            }

            var serializado = SerializarEntidad(entity);


            using (var sr = new StreamReader(rutaEscritura))
            {
                var linea = sr.ReadLine();

                while (linea != null)
                {
                    if (linea == "</" + entity.GetType().Name + "s>")
                    {
                        using (var sw = new StreamWriter(rutaBackup, true))
                        {

                            sw.WriteLine(linea);
                        }
                    }
                    else
                    {
                        using (var sw = new StreamWriter(rutaBackup, true))
                            sw.WriteLine(linea);
                    }
                }

            }

            using (var sw = new StreamWriter(rutaEscritura, true))
                sw.WriteLine(serializado);


            #region Lectura
            //var MiXMLD = new XmlDocument();
            //
            //MiXMLD.Load(@"C:\Users\czappala\Desktop\stack.xml");
            //
            //if (!(MiXMLD == null))
            //{
            //    XmlElement mXMLERaiz = MiXMLD.DocumentElement;
            //
            //    foreach (XmlNode mXMLN in mXMLERaiz.ChildNodes)
            //    {
            //        // if type is <SITE>
            //        if ((mXMLN.Name == "SITE"))
            //        {
            //            //In this point you can see the attributes
            //            if ((mXMLN.Attributes.Count > 0))
            //            {
            //                foreach (XmlAttribute mAtr in mXMLN.Attributes)
            //                {
            //                    if ((mAtr.Name == "Exalmple"))
            //                    {
            //                        var attr = mAtr.Value;
            //                    }
            //                    else if ((mAtr.Name == "Example"))
            //                    {
            //                        var attr = mAtr.Value;
            //                    }
            //                }
            //            }
            //
            //            // first node child of element of <parent>
            //            // you already know the type <Type>
            //            XmlElement mXMLchild = (XmlElement)mXMLN.FirstChild;
            //
            //            // aniway check the Type
            //            if ((mXMLchild.Name == "Type"))
            //            {
            //                var mChild = mXMLchild.FirstChild.Value;
            //            }
            //        }
            //    }
            //}
            #endregion

            //XmlDocument document = new XmlDocument();
            //document.Load(rutaEscritura);
            //
            //PropertyInfo[] props = typeof(T).GetProperties();
            //
            //
            //foreach (var item in props)
            //{
            //    var node = CrearNodo(document, entity, item);
            //    document.DocumentElement.AppendChild(node);
            //}
            //
            //
            //document.Save(rutaEscritura);


            return true;
        }

        public string GenerarRutaBackup(string rutaEscritura)
        {
            return Path.ChangeExtension(rutaEscritura, "") + "backup" + ".xml";
        }

        public XmlNode CrearNodo(XmlDocument document, T entity, PropertyInfo prop)
        {



            var val = prop.Attributes.ToString();

            XmlNode node = document.CreateNode(XmlNodeType.Element, prop.Name, null);
            node.InnerText = prop.Module.MetadataToken.ToString();

            return node;
        }



        public void Leer(T entity, string rutaEscritura)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(rutaEscritura);
        }
    }
}
