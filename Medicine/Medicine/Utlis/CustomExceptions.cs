using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine.Utlis
{
    class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        { }
    }
    class MedicineAlreadyExistsException : Exception
    {
        public MedicineAlreadyExistsException(string message) : base(message)
        { }
    }
    class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        { }
    }

}
