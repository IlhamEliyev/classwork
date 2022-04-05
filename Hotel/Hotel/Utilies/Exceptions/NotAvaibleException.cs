using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Utilies.Exceptions
{
    class NotAvaibleException:Exception
    {
        public NotAvaibleException(string msg):base(msg)
        {
        }
    }
}
