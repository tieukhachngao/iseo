namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DataContract(Namespace="http://tempuri.org/"), DebuggerStepThrough]
    public class UpdateProxyResponseBody
    {
        [DataMember(Order=0)]
        public bool UpdateProxyResult;

        public UpdateProxyResponseBody()
        {
        }

        public UpdateProxyResponseBody(bool UpdateProxyResult)
        {
            this.UpdateProxyResult = UpdateProxyResult;
        }
    }
}

