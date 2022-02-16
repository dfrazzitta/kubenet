FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:5001

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["apiback/apiback.csproj", "apiback/"]
RUN dotnet restore "apiback/apiback.csproj"
COPY . .
WORKDIR "/src/apiback"
RUN dotnet build "apiback.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "apiback.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "apiback.dll"]
