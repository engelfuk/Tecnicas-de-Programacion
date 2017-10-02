using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepcion_Forms.Exceptions
{
    class MatrixException : Exception
    {
        #region Variables Globales

        #endregion

        #region Constructores

        public MatrixException()
        {

        }

        public MatrixException(string mensaje):base(mensaje)
        {

        }
        #endregion
    }
}
