FROM mcr.microsoft.com/dotnet/core/sdk:3.1

WORKDIR /app
ADD . .
WORKDIR /app/src
RUN dotnet restore
RUN dotnet run
EXPOSE 5001 4438