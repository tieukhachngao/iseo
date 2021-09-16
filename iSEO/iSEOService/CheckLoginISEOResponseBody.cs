namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DataContract(Namespace="http://tempuri.org/"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class CheckLoginISEOResponseBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO CheckLoginISEOResult;

        public CheckLoginISEOResponseBody()
        {
        }

        public CheckLoginISEOResponseBody(InfoSEO CheckLoginISEOResult)
        {
            this.CheckLoginISEOResult = CheckLoginISEOResult;
        }
    }
}

