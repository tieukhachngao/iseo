namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough, MessageContract(IsWrapped=false), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class CheckLoginISEORequest
    {
        [MessageBodyMember(Name="CheckLoginISEO", Namespace="http://tempuri.org/", Order=0)]
        public CheckLoginISEORequestBody Body;

        public CheckLoginISEORequest()
        {
        }

        public CheckLoginISEORequest(CheckLoginISEORequestBody Body)
        {
            this.Body = Body;
        }
    }
}

