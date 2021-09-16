namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(IsWrapped=false)]
    public class GetProxyRequest
    {
        [MessageBodyMember(Name="GetProxy", Namespace="http://tempuri.org/", Order=0)]
        public GetProxyRequestBody Body;

        public GetProxyRequest()
        {
        }

        public GetProxyRequest(GetProxyRequestBody Body)
        {
            this.Body = Body;
        }
    }
}

