#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Demo.WebUI/Demo.WebUI.csproj", "Demo.WebUI/"]
RUN dotnet restore "Demo.WebUI/Demo.WebUI.csproj"
COPY . .
WORKDIR "/src/Demo.WebUI"
RUN dotnet build "Demo.WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.WebUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.WebUI.dll"]