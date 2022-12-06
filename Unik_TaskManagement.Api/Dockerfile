#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unik_TaskManagement.Api/Unik_TaskManagement.Api.csproj", "Unik_TaskManagement.Api/"]
COPY ["Unik_TaskManagement.Application/Unik_TaskManagement.Application.csproj", "Unik_TaskManagement.Application/"]
COPY ["Unik_TaskManagement.Domain/Unik_TaskManagement.Domain.csproj", "Unik_TaskManagement.Domain/"]
COPY ["Unik_TaskManagement.Persistance/Unik_TaskManagement.Persistence.csproj", "Unik_TaskManagement.Persistance/"]
RUN dotnet restore "Unik_TaskManagement.Api/Unik_TaskManagement.Api.csproj"
COPY . .
WORKDIR "/src/Unik_TaskManagement.Api"
RUN dotnet build "Unik_TaskManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unik_TaskManagement.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unik_TaskManagement.Api.dll"]