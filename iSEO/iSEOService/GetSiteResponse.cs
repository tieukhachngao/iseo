namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, MessageContract(IsWrapped=false), GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class GetSiteResponse
    {
        [MessageBodyMember(Name="GetSiteResponse", Namespace="http://tempuri.org/", Order=0)]
        public GetSiteResponseBody Body;

        public GetSiteResponse()
        {
        }

        public GetSiteResponse(GetSiteResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

