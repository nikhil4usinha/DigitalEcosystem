FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/Services/Ordering/Ordering.BackgroundTasks/Ordering.BackgroundTasks.csproj src/Services/Ordering/Ordering.BackgroundTasks/
COPY src/Core/HealthChecks/Microsoft.Extensions.HealthChecks.SqlServer/Microsoft.Extensions.HealthChecks.SqlServer.csproj src/Core/HealthChecks/Microsoft.Extensions.HealthChecks.SqlServer/
COPY src/Core/HealthChecks/Microsoft.Extensions.HealthChecks/Microsoft.Extensions.HealthChecks.csproj src/Core/HealthChecks/Microsoft.Extensions.HealthChecks/
COPY src/Core/EventBus/EventBus/EventBus.csproj src/Core/EventBus/EventBus/
COPY src/Core/EventBus/EventBusServiceBus/EventBusServiceBus.csproj src/Core/EventBus/EventBusServiceBus/
COPY src/Core/HealthChecks/Microsoft.AspNetCore.HealthChecks/Microsoft.AspNetCore.HealthChecks.csproj src/Core/HealthChecks/Microsoft.AspNetCore.HealthChecks/
RUN dotnet restore src/Services/Ordering/Ordering.BackgroundTasks/Ordering.BackgroundTasks.csproj
COPY . .
WORKDIR /src/src/Services/Ordering/Ordering.BackgroundTasks
RUN dotnet build Ordering.BackgroundTasks.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ordering.BackgroundTasks.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ordering.BackgroundTasks.dll"]
