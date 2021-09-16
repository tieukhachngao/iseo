namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(IsWrapped=false), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class UpdateProxyRequest
    {
        [MessageBodyMember(Name="UpdateProxy", Namespace="http://tempuri.org/", Order=0)]
        public UpdateProxyRequestBody Body;

        public UpdateProxyRequest()
        {
        }

        public UpdateProxyRequest(UpdateProxyRequestBody Body)
        {
            this.Body = Body;
        }
    }
}

