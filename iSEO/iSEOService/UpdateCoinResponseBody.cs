namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), DataContract(Namespace="http://tempuri.org/"), DebuggerStepThrough]
    public class UpdateCoinResponseBody
    {
        [DataMember(Order=0)]
        public bool UpdateCoinResult;

        public UpdateCoinResponseBody()
        {
        }

        public UpdateCoinResponseBody(bool UpdateCoinResult)
        {
            this.UpdateCoinResult = UpdateCoinResult;
        }
    }
}

