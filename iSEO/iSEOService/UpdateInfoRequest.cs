namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(IsWrapped=false)]
    public class UpdateInfoRequest
    {
        [MessageBodyMember(Name="UpdateInfo", Namespace="http://tempuri.org/", Order=0)]
        public UpdateInfoRequestBody Body;

        public UpdateInfoRequest()
        {
        }

        public UpdateInfoRequest(UpdateInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
}

