FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GrpcWithRest/GrpcWithRest.csproj", "GrpcWithRest/"]
RUN dotnet restore "GrpcWithRest/GrpcWithRest.csproj"
COPY . .
WORKDIR "/src/GrpcWithRest"
RUN dotnet build "GrpcWithRest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcWithRest.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcWithRest.dll"]
