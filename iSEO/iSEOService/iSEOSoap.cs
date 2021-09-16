namespace iSEO.iSEOService
{
    using System.CodeDom.Compiler;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(ConfigurationName="iSEOService.iSEOSoap")]
    public interface iSEOSoap
    {
        [OperationContract(Action="http://tempuri.org/CheckLoginISEO", ReplyAction="*")]
        CheckLoginISEOResponse CheckLoginISEO(CheckLoginISEORequest request);
        [OperationContract(Action="http://tempuri.org/GetProxy", ReplyAction="*")]
        GetProxyResponse GetProxy(GetProxyRequest request);
        [OperationContract(Action="http://tempuri.org/GetSite", ReplyAction="*")]
        GetSiteResponse GetSite(GetSiteRequest request);
        [OperationContract(Action="http://tempuri.org/UpdateCoin", ReplyAction="*")]
        UpdateCoinResponse UpdateCoin(UpdateCoinRequest request);
        [OperationContract(Action="http://tempuri.org/UpdateInfo", ReplyAction="*")]
        UpdateInfoResponse UpdateInfo(UpdateInfoRequest request);
        [OperationContract(Action="http://tempuri.org/UpdateProxy", ReplyAction="*")]
        UpdateProxyResponse UpdateProxy(UpdateProxyRequest request);
    }
}

