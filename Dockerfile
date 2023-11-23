FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
ADD . .
WORKDIR /app/scr/TrelloClone
RUN dotnet restore
RUN dotnet run
EXPOSE 5001 4438
