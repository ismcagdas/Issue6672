FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Issue6672.Web.Host/Issue6672.Web.Host.csproj", "src/Issue6672.Web.Host/"]
COPY ["src/Issue6672.Web.Core/Issue6672.Web.Core.csproj", "src/Issue6672.Web.Core/"]
COPY ["src/Issue6672.Application/Issue6672.Application.csproj", "src/Issue6672.Application/"]
COPY ["src/Issue6672.Core/Issue6672.Core.csproj", "src/Issue6672.Core/"]
COPY ["src/Issue6672.EntityFrameworkCore/Issue6672.EntityFrameworkCore.csproj", "src/Issue6672.EntityFrameworkCore/"]
WORKDIR "/src/src/Issue6672.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Issue6672.Web.Host", "src/Issue6672.Web.Host"]
COPY ["src/Issue6672.Web.Core", "src/Issue6672.Web.Core"]
COPY ["src/Issue6672.Application", "src/Issue6672.Application"]
COPY ["src/Issue6672.Core", "src/Issue6672.Core"]
COPY ["src/Issue6672.EntityFrameworkCore", "src/Issue6672.EntityFrameworkCore"]
WORKDIR "/src/src/Issue6672.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Issue6672.Web.Host.dll"]
