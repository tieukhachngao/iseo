namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DataContract(Namespace="http://tempuri.org/"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough]
    public class UpdateCoinRequestBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO info;

        public UpdateCoinRequestBody()
        {
        }

        public UpdateCoinRequestBody(InfoSEO info)
        {
            this.info = info;
        }
    }
}

