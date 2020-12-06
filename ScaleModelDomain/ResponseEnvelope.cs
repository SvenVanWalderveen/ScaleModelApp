using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain
{
    public class ResponseEnvelopeWithDataResult<T>
    {
        public ResponseEnvelopeWithDataResult()
        {

        }
        public ResponseEnvelopeWithDataResult(Exception exception)
        {
            this.Exception = exception;
            this.CallSuccessfull = false;
        }

        public T DataResult { get; set; }
        public bool CallSuccessfull { get; set; }
        public Exception Exception { get; set; }
    }

    public class ResponseEnvelope
    {
        public ResponseEnvelope()
        {
            this.CallSuccessfull = true;
        }
        public ResponseEnvelope(Exception exception)
        {
            this.Exception = exception;
            this.CallSuccessfull = false;
        }
        public ResponseEnvelope(string errorMessage)
        {
            this.Exception = new Exception(errorMessage);                
            this.CallSuccessfull = false;
        }
        public bool CallSuccessfull { get; set; }
        public Exception Exception { get; set; }
    }
}

