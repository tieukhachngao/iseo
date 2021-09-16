namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(IsWrapped=false), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class CheckLoginISEOResponse
    {
        [MessageBodyMember(Name="CheckLoginISEOResponse", Namespace="http://tempuri.org/", Order=0)]
        public CheckLoginISEOResponseBody Body;

        public CheckLoginISEOResponse()
        {
        }

        public CheckLoginISEOResponse(CheckLoginISEOResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

