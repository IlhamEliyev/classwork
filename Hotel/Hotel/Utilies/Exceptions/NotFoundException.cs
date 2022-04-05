using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Utilies.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string msg):base(msg)
        {

        }
    }
}
