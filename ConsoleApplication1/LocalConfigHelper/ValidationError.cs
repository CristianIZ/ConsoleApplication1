using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.UserInterface
{
    public class ValidationError : Exception
    {
        public MessageEnum MessageEnum { get; set; }
        public ValidationError(MessageEnum messageEnum)
        {
            this.MessageEnum = messageEnum;
        }
    }
}
