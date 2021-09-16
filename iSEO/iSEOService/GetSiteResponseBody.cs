namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DataContract(Namespace="http://tempuri.org/"), EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
    public class GetSiteResponseBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO[] GetSiteResult;

        public GetSiteResponseBody()
        {
        }

        public GetSiteResponseBody(InfoSEO[] GetSiteResult)
        {
            this.GetSiteResult = GetSiteResult;
        }
    }
}

