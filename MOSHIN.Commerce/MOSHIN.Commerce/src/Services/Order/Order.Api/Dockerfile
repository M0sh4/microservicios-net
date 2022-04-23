#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Api/Order.Api.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Api/"]
COPY ["MOSHIN.Commerce/src/Services/Order/Order.Api/Order.Api.csproj", "./Order/"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Persistence.Database/Order.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Persistence.Database/"]
COPY ["Order.Persistence.Database.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Domain/Order.Domain.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Domain/"]
COPY ["Order.Domain.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Common/Order.Common.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Common/"]
COPY ["Order.Common.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Persistence.Database/Customer.Persistence.Database.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Persistence.Database/"]
COPY ["Customer.Persistence.Database.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Customer/Customer.Domain/Customer.Domain.csproj", "MOSHIN.Commerce/src/Services/Customer/Customer.Domain/"]
COPY ["Customer.Domain.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Service.Queries/Order.Service.Queries.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Service.Queries/"]
COPY ["Order.Service.Queries.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/Service.Common.Collection.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Collection/"]
COPY ["Service.Common.Collection.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/Service.Common.Mapping.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Mapping/"]
COPY ["Service.Common.Mapping.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/Service.Common.Paging.csproj", "MOSHIN.Commerce/src/Services/Common/Service.Common.Paging/"]
COPY ["Service.Common.Paging.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Service.Proxy/Order.Service.Proxies.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Service.Proxy/"]
COPY ["Order.Service.Proxies.csproj", "./"]
#COPY ["MOSHIN.Commerce/src/Services/Order/Order.Service.EventHandlers/Order.Service.EventHandlers.csproj", "MOSHIN.Commerce/src/Services/Order/Order.Service.EventHandlers/"]
COPY ["Order.Service.EventHandlers.csproj", "./"]
#RUN dotnet restore "MOSHIN.Commerce/src/Services/Order/Order.Api/Order.Api.csproj"
RUN dotnet restore "Order.Api.csproj"

COPY . .
#WORKDIR "/src/MOSHIN.Commerce/src/Services/Order/Order.Api"
WORKDIR "/src"
RUN dotnet build "Order.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Order.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Order.Api.dll"]