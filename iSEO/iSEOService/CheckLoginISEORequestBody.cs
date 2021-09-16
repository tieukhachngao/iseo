namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), DataContract(Namespace="http://tempuri.org/"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class CheckLoginISEORequestBody
    {
        [DataMember(EmitDefaultValue=false, Order=0)]
        public InfoSEO info;

        public CheckLoginISEORequestBody()
        {
        }

        public CheckLoginISEORequestBody(InfoSEO info)
        {
            this.info = info;
        }
    }
}

