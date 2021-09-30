FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OGenDash/OGenDash.csproj", "OGenDash/"]
RUN dotnet restore "OGenDash/OGenDash.csproj"
COPY . .
WORKDIR "/src/OGenDash"
RUN dotnet build "OGenDash.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OGenDash.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OGenDash.dll"]
