using System;
using System.Collections.Generic;
using System.Text;

namespace My_Project.Business.Exceptions
{
    internal class NotfoundException : Exception
    {
        public NotfoundException(string message) : base(message)
        {
        }
    }
}
