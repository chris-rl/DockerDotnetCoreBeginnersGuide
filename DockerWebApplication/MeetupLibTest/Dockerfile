FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MeetupLibTest/MeetupLibTest.csproj", "MeetupLibTest/"]
COPY ["MeetupLib/MeetupLib.csproj", "MeetupLib/"]
RUN dotnet restore "MeetupLibTest/MeetupLibTest.csproj"
COPY . .
WORKDIR "/src/MeetupLibTest"
RUN dotnet build "MeetupLibTest.csproj" -c Release -o /app/build
ENTRYPOINT [ "dotnet"]

FROM build AS publish
RUN dotnet publish "MeetupLibTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test", "MeetupLibTest.dll"]