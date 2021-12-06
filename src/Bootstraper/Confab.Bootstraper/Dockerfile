FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Bootstraper/Confab.Bootstraper/Confab.Bootstraper.csproj", "Confab.Bootstraper/"]
RUN dotnet restore "src/Bootstraper/Confab.Bootstraper/Confab.Bootstraper.csproj"
COPY . .
WORKDIR "/src/Confab.Bootstraper"
RUN dotnet build "Confab.Bootstraper.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Confab.Bootstraper.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Confab.Bootstraper.dll"]
