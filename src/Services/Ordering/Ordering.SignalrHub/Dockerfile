FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/Services/Ordering/Ordering.SignalrHub/Ordering.SignalrHub.csproj src/Services/Ordering/Ordering.SignalrHub/
COPY src/Core/EventBus/EventBus/EventBus.csproj src/Core/EventBus/EventBus/
COPY src/Core/EventBus/EventBusServiceBus/EventBusServiceBus.csproj src/Core/EventBus/EventBusServiceBus/
RUN dotnet restore src/Services/Ordering/Ordering.SignalrHub/Ordering.SignalrHub.csproj
COPY . .
WORKDIR /src/src/Services/Ordering/Ordering.SignalrHub
RUN dotnet build Ordering.SignalrHub.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ordering.SignalrHub.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ordering.SignalrHub.dll"]
