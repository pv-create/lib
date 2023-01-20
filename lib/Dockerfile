FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["lib/lib.csproj", "lib/"]
RUN dotnet restore "lib/lib.csproj"
COPY . .
WORKDIR "/src/lib"
RUN dotnet build "lib.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lib.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lib.dll"]
