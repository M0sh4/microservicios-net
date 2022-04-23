#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["MOSHIN.Commerce/src/Gateways/Api.Gateway.WebClient/Api.Gateway.WebClient.csproj", "MOSHIN.Commerce/src/Gateways/Api.Gateway.WebClient/"]
COPY ["Api.Gateway.WebClient.csproj", "./"]
#RUN dotnet restore "MOSHIN.Commerce/src/Gateways/Api.Gateway.WebClient/Api.Gateway.WebClient.csproj"
RUN dotnet restore "Api.Gateway.WebClient.csproj"

COPY . .
#WORKDIR "/src/MOSHIN.Commerce/src/Gateways/Api.Gateway.WebClient"
WORKDIR "/src"
RUN dotnet build "Api.Gateway.WebClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Gateway.WebClient.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Gateway.WebClient.dll"]