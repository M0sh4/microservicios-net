#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Api/Customer.Api.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Api/"]
COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Service.EventHandlers/Customer.Service.EventHandlers.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Service.EventHandlers/"]
COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Persistence.Database/Customer.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Persistence.Database/"]
COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Domain/Customer.Domain.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Domain/"]
COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.PersistenceDatabase/Catalog.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.PersistenceDatabase/"]
COPY ["MOSHIN.Commerce/src/Services/Catalog/Catalog.Domain/Catalog.Domain.csproj", "MOSHIN.Commerce/src/Services/Catalog/Catalog.Domain/"]
COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Service.Queries/Customer.Service.Queries.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Service.Queries/"]
COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/Service.Common.Collection.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/"]
COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/Service.Common.Mapping.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/"]
COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/Service.Common.Paging.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/"]
RUN dotnet restore "MOSHIN.Commerce/src/Services/Customer/Customer.Api/Customer.Api.csproj"
COPY . .
WORKDIR "/src/MOSHIN.Commerce/src/Services/Customer/Customer.Api"
RUN dotnet build "Customer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Customer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Customer.Api.dll"]