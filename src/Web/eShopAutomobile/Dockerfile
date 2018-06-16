FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/Web/eShopAutomobile/eShopAutomobile.csproj src/Web/eShopAutomobile/
COPY src/Core/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj src/Core/EventBus/IntegrationEventLogEF/
COPY src/Core/EventBus/EventBusServiceBus/EventBusServiceBus.csproj src/Core/EventBus/EventBusServiceBus/
COPY src/Core/EventBus/EventBus/EventBus.csproj src/Core/EventBus/EventBus/
RUN dotnet restore src/Web/eShopAutomobile/eShopAutomobile.csproj
COPY . .
WORKDIR /src/src/Web/eShopAutomobile
RUN dotnet build eShopAutomobile.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish eShopAutomobile.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "eShopAutomobile.dll"]
