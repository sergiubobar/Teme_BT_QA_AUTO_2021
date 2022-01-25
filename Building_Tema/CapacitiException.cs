using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class CapacitiException: Exception
    {
        string exceptionMessage;

        public CapacitiException(string message)
        {
            this.exceptionMessage += message;
        }

        public override string ToString()
        {
            return exceptionMessage + base.ToString();
        }
    }
}
