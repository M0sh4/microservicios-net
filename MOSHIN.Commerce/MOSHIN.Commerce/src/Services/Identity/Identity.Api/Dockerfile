#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["MOSHIN.Commerce/src/Services/Identity/Identity.Api/Identity.Api.csproj", "MOSHIN.Commerce/src/Services/Identity/Identity.Api/"]
COPY ["Identity.Api/Identity.Api.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Identity/Identity.Service.EventHandler/Identity.Service.EventHandlers.csproj", "MOSHIN.Commerce/src/Services/Identity/Identity.Service.EventHandler/"]
COPY ["Identity.Service.EventHandler/Identity.Service.EventHandlers.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Identity/Identity.Domain/Identity.Domain.csproj", "MOSHIN.Commerce/src/Services/Identity/Identity.Domain/"]
COPY ["Identity.Domain/Identity.Domain.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Identity/Identity.Persistence.Database/Identity.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Identity/Identity.Persistence.Database/"]
COPY ["Identity.Persistence.Database/Identity.Persistence.Database.csproj", "./"]

#RUN dotnet restore "MOSHIN.Commerce/src/Services/Identity/Identity.Api/Identity.Api.csproj"
RUN dotnet restore "Identity.Api.csproj"

COPY . .
#WORKDIR "/src/MOSHIN.Commerce/src/Services/Identity/Identity.Api"
WORKDIR "/src"
RUN dotnet build "Identity.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Identity.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Identity.Api.dll"]