using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensus
{
    public class CensusCustomException : Exception
    {
        public enum CensusCustomExceptionType
        {
            INCORRECT_FILE
        }
        public CensusCustomExceptionType type;

        public CensusCustomException(CensusCustomExceptionType Type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
