﻿using System;
using SlackNet.Handlers;

namespace SlackNet
{
    /// <summary>
    /// A basic factory for SlackNet services, with some configuration.
    /// If you're using a dependency injection library, you're probably better off integrating with that instead of using this.
    /// </summary>
    public class SlackServiceFactory : SlackServiceConfigurationBase<SlackServiceFactory>, ISlackServiceFactory
    {
        private readonly Lazy<ISlackServiceFactory> _factory;

        public SlackServiceFactory() => _factory = new Lazy<ISlackServiceFactory>(() => CreateServiceFactory(this));

        public IHttp GetHttp() => _factory.Value.GetHttp();
        public SlackJsonSettings GetJsonSettings() => _factory.Value.GetJsonSettings();
        public ISlackTypeResolver GetTypeResolver() => _factory.Value.GetTypeResolver();
        public ISlackUrlBuilder GetUrlBuilder() => _factory.Value.GetUrlBuilder();
        public IWebSocketFactory GetWebSocketFactory() => _factory.Value.GetWebSocketFactory();
        public ISlackRequestContextFactory GetRequestContextFactory() => _factory.Value.GetRequestContextFactory();
        public ISlackRequestListener GetRequestListener() => _factory.Value.GetRequestListener();
        public ISlackHandlerFactory GetHandlerFactory() => _factory.Value.GetHandlerFactory();
        public ISlackApiClient GetApiClient() => _factory.Value.GetApiClient();
        public ISlackSocketModeClient GetSocketModeClient() => _factory.Value.GetSocketModeClient();
    }
}
