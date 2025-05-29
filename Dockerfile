# 1. Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Proje dosyasını ayrı kopyala ve restore yap
COPY *.csproj ./
RUN dotnet restore

# Tüm dosyaları kopyala ve build et
COPY . ./
RUN dotnet publish -c Release -o /app/out

# 2. Runtime aşaması
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "Basics.dll"]
EXPOSE 8080
