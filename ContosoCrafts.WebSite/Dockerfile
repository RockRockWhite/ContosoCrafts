﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ContosoCrafts.WebSite/ContosoCrafts.WebSite.csproj", "ContosoCrafts.WebSite/"]
RUN dotnet restore "ContosoCrafts.WebSite/ContosoCrafts.WebSite.csproj"
COPY . .
WORKDIR "/src/ContosoCrafts.WebSite"
RUN dotnet build "ContosoCrafts.WebSite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContosoCrafts.WebSite.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContosoCrafts.WebSite.dll"]
