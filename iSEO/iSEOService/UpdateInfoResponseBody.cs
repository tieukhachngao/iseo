namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), DataContract(Namespace="http://tempuri.org/"), DebuggerStepThrough]
    public class UpdateInfoResponseBody
    {
        [DataMember(Order=0)]
        public bool UpdateInfoResult;

        public UpdateInfoResponseBody()
        {
        }

        public UpdateInfoResponseBody(bool UpdateInfoResult)
        {
            this.UpdateInfoResult = UpdateInfoResult;
        }
    }
}

