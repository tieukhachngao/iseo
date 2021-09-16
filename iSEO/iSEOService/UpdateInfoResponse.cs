namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(IsWrapped=false), DebuggerStepThrough]
    public class UpdateInfoResponse
    {
        [MessageBodyMember(Name="UpdateInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public UpdateInfoResponseBody Body;

        public UpdateInfoResponse()
        {
        }

        public UpdateInfoResponse(UpdateInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

