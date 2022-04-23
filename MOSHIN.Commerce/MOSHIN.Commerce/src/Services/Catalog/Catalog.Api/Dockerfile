#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.Api/Catalog.Api.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.Api/"]
COPY ["Catalog.Api.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.PersistenceDatabase/Catalog.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.PersistenceDatabase/"]
COPY ["Catalog.Persistence.Database.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.Domain/Catalog.Domain.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.Domain/"]
COPY ["Catalog.Domain.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.Service.EventHandlers/Catalog.Service.EventHandlers.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.Service.EventHandlers/"]
COPY ["Catalog.Service.EventHandlers.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.Common/Catalog.Common.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.Common/"]
COPY ["Catalog.Common.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.ServiceQueries/Catalog.Service.Queries.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.ServiceQueries/"]
COPY ["Catalog.Service.Queries.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/Service.Common.Collection.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/"]
COPY ["Service.Common.Collection.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/Service.Common.Mapping.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/"]
COPY ["Service.Common.Mapping.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/Service.Common.Paging.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/"]
COPY ["Service.Common.Paging.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Common.Logging/Service.Common.Logging.csproj", "MOSHIN.Commerce/src/Services/Common/Common.Logging/"]
COPY ["Service.Common.Logging.csproj", "./"]

#RUN dotnet restore "MOSHIN.Commerce/src/Services/Catalog/Catalog.Api/Catalog.Api.csproj"
RUN dotnet restore "Catalog.Api.csproj"

COPY . .
#WORKDIR "/src/MOSHIN.Commerce/src/Services/Catalog/Catalog.Api"
WORKDIR "/src"
RUN dotnet build "Catalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.Api.dll"]