namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(IsWrapped=false), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough]
    public class UpdateCoinRequest
    {
        [MessageBodyMember(Name="UpdateCoin", Namespace="http://tempuri.org/", Order=0)]
        public UpdateCoinRequestBody Body;

        public UpdateCoinRequest()
        {
        }

        public UpdateCoinRequest(UpdateCoinRequestBody Body)
        {
            this.Body = Body;
        }
    }
}

