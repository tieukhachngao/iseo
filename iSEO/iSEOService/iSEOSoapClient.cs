namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class iSEOSoapClient : ClientBase<iSEOSoap>, iSEOSoap
    {
        public iSEOSoapClient()
        {
        }

        public iSEOSoapClient(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public iSEOSoapClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public iSEOSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public iSEOSoapClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public InfoSEO CheckLoginISEO(InfoSEO info)
        {
            CheckLoginISEORequest request = new CheckLoginISEORequest {
                Body = new CheckLoginISEORequestBody()
            };
            request.Body.info = info;
            return ((iSEOSoap) this).CheckLoginISEO(request).Body.CheckLoginISEOResult;
        }

        public string GetProxy()
        {
            GetProxyRequest request = new GetProxyRequest {
                Body = new GetProxyRequestBody()
            };
            return ((iSEOSoap) this).GetProxy(request).Body.GetProxyResult;
        }

        public InfoSEO[] GetSite(InfoSEO info)
        {
            GetSiteRequest request = new GetSiteRequest {
                Body = new GetSiteRequestBody()
            };
            request.Body.info = info;
            return ((iSEOSoap) this).GetSite(request).Body.GetSiteResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        CheckLoginISEOResponse iSEOSoap.CheckLoginISEO(CheckLoginISEORequest request) => 
            base.Channel.CheckLoginISEO(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetProxyResponse iSEOSoap.GetProxy(GetProxyRequest request) => 
            base.Channel.GetProxy(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetSiteResponse iSEOSoap.GetSite(GetSiteRequest request) => 
            base.Channel.GetSite(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateCoinResponse iSEOSoap.UpdateCoin(UpdateCoinRequest request) => 
            base.Channel.UpdateCoin(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateInfoResponse iSEOSoap.UpdateInfo(UpdateInfoRequest request) => 
            base.Channel.UpdateInfo(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateProxyResponse iSEOSoap.UpdateProxy(UpdateProxyRequest request) => 
            base.Channel.UpdateProxy(request);

        public bool UpdateCoin(InfoSEO info)
        {
            UpdateCoinRequest request = new UpdateCoinRequest {
                Body = new UpdateCoinRequestBody()
            };
            request.Body.info = info;
            return ((iSEOSoap) this).UpdateCoin(request).Body.UpdateCoinResult;
        }

        public bool UpdateInfo(InfoSEO info)
        {
            UpdateInfoRequest request = new UpdateInfoRequest {
                Body = new UpdateInfoRequestBody()
            };
            request.Body.info = info;
            return ((iSEOSoap) this).UpdateInfo(request).Body.UpdateInfoResult;
        }

        public bool UpdateProxy(InfoSEO info)
        {
            UpdateProxyRequest request = new UpdateProxyRequest {
                Body = new UpdateProxyRequestBody()
            };
            request.Body.info = info;
            return ((iSEOSoap) this).UpdateProxy(request).Body.UpdateProxyResult;
        }
    }
}

