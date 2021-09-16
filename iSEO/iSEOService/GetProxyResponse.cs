namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(IsWrapped=false), EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
    public class GetProxyResponse
    {
        [MessageBodyMember(Name="GetProxyResponse", Namespace="http://tempuri.org/", Order=0)]
        public GetProxyResponseBody Body;

        public GetProxyResponse()
        {
        }

        public GetProxyResponse(GetProxyResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

