namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, DataContract(Namespace="http://tempuri.org/")]
    public class UpdateProxyRequestBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO info;

        public UpdateProxyRequestBody()
        {
        }

        public UpdateProxyRequestBody(InfoSEO info)
        {
            this.info = info;
        }
    }
}

