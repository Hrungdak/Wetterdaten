using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Exceptions
{
    public class ZipNotFoundException : Exception
    {
        public ZipNotFoundException(string zip) : base($"Zip not found: {zip}")
        {
        }
    }
}