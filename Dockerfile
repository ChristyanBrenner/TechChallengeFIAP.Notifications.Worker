FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY CloudGames.Notifications.Worker/*.csproj ./CloudGames.Notifications.Worker/
COPY Consumers/*.csproj ./Consumers/

# Ignora restore
# RUN dotnet restore

COPY . .

# Cria pasta /app mesmo sem publicar
RUN mkdir -p /app

WORKDIR /src/CloudGames.Notifications.Worker

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["sleep", "infinity"]