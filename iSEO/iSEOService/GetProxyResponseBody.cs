namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DataContract(Namespace="http://tempuri.org/")]
    public class GetProxyResponseBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public string GetProxyResult;

        public GetProxyResponseBody()
        {
        }

        public GetProxyResponseBody(string GetProxyResult)
        {
            this.GetProxyResult = GetProxyResult;
        }
    }
}

