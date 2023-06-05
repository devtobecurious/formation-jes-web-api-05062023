#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["StarwarsGame.Web.API.UI/StarwarsGame.Web.API.UI.csproj", "StarwarsGame.Web.API.UI/"]
RUN dotnet restore "StarwarsGame.Web.API.UI/StarwarsGame.Web.API.UI.csproj"
COPY . .
WORKDIR "/src/StarwarsGame.Web.API.UI"
RUN dotnet build "StarwarsGame.Web.API.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StarwarsGame.Web.API.UI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StarwarsGame.Web.API.UI.dll"]