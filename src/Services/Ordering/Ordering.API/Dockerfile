FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/Services/Ordering/Ordering.API/Ordering.API.csproj src/Services/Ordering/Ordering.API/
COPY src/Core/HealthChecks/Microsoft.Extensions.HealthChecks.SqlServer/Microsoft.Extensions.HealthChecks.SqlServer.csproj src/Core/HealthChecks/Microsoft.Extensions.HealthChecks.SqlServer/
COPY src/Core/HealthChecks/Microsoft.Extensions.HealthChecks/Microsoft.Extensions.HealthChecks.csproj src/Core/HealthChecks/Microsoft.Extensions.HealthChecks/
COPY src/Services/Ordering/Ordering.Domain/Ordering.Domain.csproj src/Services/Ordering/Ordering.Domain/
COPY src/Core/HealthChecks/Microsoft.AspNetCore.HealthChecks/Microsoft.AspNetCore.HealthChecks.csproj src/Core/HealthChecks/Microsoft.AspNetCore.HealthChecks/
COPY src/Core/WebHostCustomization/WebHost.Customization/WebHost.Customization.csproj src/Core/WebHostCustomization/WebHost.Customization/
COPY src/Core/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj src/Core/EventBus/IntegrationEventLogEF/
COPY src/Core/EventBus/EventBusServiceBus/EventBusServiceBus.csproj src/Core/EventBus/EventBusServiceBus/
COPY src/Core/EventBus/EventBus/EventBus.csproj src/Core/EventBus/EventBus/
COPY src/Services/Ordering/Ordering.Infrastructure/Ordering.Infrastructure.csproj src/Services/Ordering/Ordering.Infrastructure/
RUN dotnet restore src/Services/Ordering/Ordering.API/Ordering.API.csproj
COPY . .
WORKDIR /src/src/Services/Ordering/Ordering.API
RUN dotnet build Ordering.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ordering.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ordering.API.dll"]
