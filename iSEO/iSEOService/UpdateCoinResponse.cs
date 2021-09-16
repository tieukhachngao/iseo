namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped=false), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class UpdateCoinResponse
    {
        [MessageBodyMember(Name="UpdateCoinResponse", Namespace="http://tempuri.org/", Order=0)]
        public UpdateCoinResponseBody Body;

        public UpdateCoinResponse()
        {
        }

        public UpdateCoinResponse(UpdateCoinResponseBody Body)
        {
            this.Body = Body;
        }
    }
}

