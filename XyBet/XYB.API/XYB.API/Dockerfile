FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["XYB.API/XYB.API.csproj", "XYB.API/"]
RUN dotnet restore "XYB.API/XYB.API.csproj"
COPY . .
WORKDIR "/src/XYB.API"
RUN dotnet build "XYB.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XYB.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XYB.API.dll"]