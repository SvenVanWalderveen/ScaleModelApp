using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleModelDomain.Interfaces
{
    interface IDatabaseEntity
    {
        ResponseEnvelope Create(object obj);
        ResponseEnvelopeWithDataResult<List<object>> Read();
        ResponseEnvelope Update(object obj);
        ResponseEnvelope Delete(Guid id);
    }
}
