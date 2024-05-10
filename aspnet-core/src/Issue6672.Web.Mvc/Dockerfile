FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/Issue6672.Web.Mvc/Issue6672.Web.Mvc.csproj", "src/Issue6672.Web.Mvc/"]
COPY ["src/Issue6672.Web.Core/Issue6672.Web.Core.csproj", "src/Issue6672.Web.Core/"]
COPY ["src/Issue6672.Application/Issue6672.Application.csproj", "src/Issue6672.Application/"]
COPY ["src/Issue6672.Core/Issue6672.Core.csproj", "src/Issue6672.Core/"]
COPY ["src/Issue6672.EntityFrameworkCore/Issue6672.EntityFrameworkCore.csproj", "src/Issue6672.EntityFrameworkCore/"]
WORKDIR "/src/src/Issue6672.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Issue6672.Web.Mvc", "src/Issue6672.Web.Mvc"]
COPY ["src/Issue6672.Web.Core", "src/Issue6672.Web.Core"]
COPY ["src/Issue6672.Application", "src/Issue6672.Application"]
COPY ["src/Issue6672.Core", "src/Issue6672.Core"]
COPY ["src/Issue6672.EntityFrameworkCore", "src/Issue6672.EntityFrameworkCore"]
WORKDIR "/src/src/Issue6672.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Issue6672.Web.Mvc.dll"]
