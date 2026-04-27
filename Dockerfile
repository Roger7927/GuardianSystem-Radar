# (c) 2026 Guillermo Roger Hernandez Chandia - ADS
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia o projeto e restaura as dependências (Bolinhas)
COPY *.csproj ./
RUN dotnet restore

# Copia tudo e compila
COPY . ./
RUN dotnet publish -c Release -o out

# Gera a imagem final de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "GuardianSystem.dll"]
