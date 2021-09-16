namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), DataContract(Namespace="http://tempuri.org/")]
    public class UpdateInfoRequestBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO info;

        public UpdateInfoRequestBody()
        {
        }

        public UpdateInfoRequestBody(InfoSEO info)
        {
            this.info = info;
        }
    }
}

