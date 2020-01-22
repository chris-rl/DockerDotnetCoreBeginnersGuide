FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["DockerWebApplication/DockerWebApplication.csproj", "DockerWebApplication/"]
COPY ["MeetupLib/MeetupLib.csproj", "MeetupLib/"]
RUN dotnet restore "DockerWebApplication/DockerWebApplication.csproj"
COPY . .
WORKDIR "/src/DockerWebApplication"
RUN dotnet build "DockerWebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerWebApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerWebApplication.dll"]