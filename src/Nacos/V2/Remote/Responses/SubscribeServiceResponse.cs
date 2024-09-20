﻿namespace Nacos.V2.Remote.Responses
{
    public class SubscribeServiceResponse : CommonResponse
    {
        [System.Text.Json.Serialization.JsonPropertyName("serviceInfo")]
        public Nacos.V2.Naming.Dtos.ServiceInfo ServiceInfo { get; set; }

        public override string GetRemoteType() => RemoteRequestType.Resp_Naming_SubscribeService;
    }
}
