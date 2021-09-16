namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DebuggerStepThrough, DataContract(Namespace="http://tempuri.org/"), EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetSiteRequestBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO info;

        public GetSiteRequestBody()
        {
        }

        public GetSiteRequestBody(InfoSEO info)
        {
            this.info = info;
        }
    }
}

