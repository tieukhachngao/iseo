namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough, MessageContract(IsWrapped=false), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class UpdateProxyResponse
    {
        [MessageBodyMember(Name="UpdateProxyResponse", Namespace="http://tempuri.org/", Order=0)]
        public UpdateProxyResponseBody Body;

        public UpdateProxyResponse()
        {
        }

        public UpdateProxyResponse(UpdateProxyResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

