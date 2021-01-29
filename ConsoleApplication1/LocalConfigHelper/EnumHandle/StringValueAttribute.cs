using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.UserInterface
{
    internal class StringValueAttribute : Attribute
    {
        public string StringValue { get; }
        public StringValueAttribute(string v)
        {
            StringValue = v;
        }
    }
}
