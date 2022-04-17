FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["../Claims2.App/Claims2.App/Claims2.App.csproj", "Claims2.App/"]
RUN dotnet restore "../Claims2.App/Claims2.App/Claims2.App.csproj"
COPY . .
WORKDIR "/src/Claims2.App"
RUN dotnet build "Claims2.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Claims2.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Claims2.App.dll"]
