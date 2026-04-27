# (c) 2026 Guillermo Roger Hernandez Chandia - ADS
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GuardianSystem.csproj", "."]
RUN dotnet restore "./GuardianSystem.csproj"
COPY . .
RUN dotnet build "GuardianSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GuardianSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GuardianSystem.dll"]
