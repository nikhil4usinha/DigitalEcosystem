FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY eShopOnContainers-ServicesAndWebApps.sln ./
COPY src/Services/Ordering/Forecasting.SignalrHub/Forecasting.SignalrHub.csproj src/Services/Ordering/Forecasting.SignalrHub/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/src/Services/Ordering/Forecasting.SignalrHub
RUN dotnet build Forecasting.SignalrHub.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Forecasting.SignalrHub.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Forecasting.SignalrHub.dll"]
