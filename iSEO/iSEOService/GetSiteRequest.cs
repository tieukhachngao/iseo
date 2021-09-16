namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(IsWrapped=false), DebuggerStepThrough]
    public class GetSiteRequest
    {
        [MessageBodyMember(Name="GetSite", Namespace="http://tempuri.org/", Order=0)]
        public GetSiteRequestBody Body;

        public GetSiteRequest()
        {
        }

        public GetSiteRequest(GetSiteRequestBody Body)
        {
            this.Body = Body;
        }
    }
}

