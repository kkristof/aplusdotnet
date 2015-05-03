using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplusCore.Runtime.Function.ADAP
{
    public enum ADAPExceptionType
    {
        Import,
        Export
    }

    public class ADAPException : Exception
    {
        #region Variables

        private ADAPExceptionType type;

        #endregion

        #region Properties

        public ADAPExceptionType Type { get { return this.type; } }

        #endregion

        #region Constructors

        public ADAPException(ADAPExceptionType exceptionType)
            : base()
        {
            this.type = exceptionType;
        }

        public ADAPException(ADAPExceptionType exceptionType, string message)
            : base(message)
        {
            this.type = exceptionType;
        }

        public ADAPException(ADAPExceptionType exceptionType, string message, Exception innerEx)
            : base(message, innerEx)
        {
            this.type = exceptionType;
        }

        #endregion
    }
}
