FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PasswordHasherApp/PasswordHasherApp.csproj", "PasswordHasherApp/"]
RUN dotnet restore "PasswordHasherApp/PasswordHasherApp.csproj"
COPY . .
WORKDIR "/src/PasswordHasherApp"
RUN dotnet build "PasswordHasherApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PasswordHasherApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PasswordHasherApp.dll"]
