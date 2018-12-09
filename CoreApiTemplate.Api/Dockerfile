FROM microsoft/dotnet:sdk AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:sdk AS build
WORKDIR /src
COPY ["CoreApiTemplate.Api/CoreApiTemplate.Api.csproj", "CoreApiTemplate.Api/"]
COPY ["CoreApiTemplate.Data/CoreApiTemplate.Data.csproj", "CoreApiTemplate.Data/"]
COPY ["CoreApiTemplate.Models/CoreApiTemplate.Models.csproj", "CoreApiTemplate.Models/"]
COPY ["CoreApiTemplate.Core/CoreApiTemplate.Core.csproj", "CoreApiTemplate.Core/"]
COPY ["CoreApiTemplate.Business/CoreApiTemplate.Business.csproj", "CoreApiTemplate.Business/"]

RUN dotnet restore "CoreApiTemplate.Api/CoreApiTemplate.Api.csproj"

COPY . .

WORKDIR "/src/CoreApiTemplate.Api"
RUN dotnet build "CoreApiTemplate.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CoreApiTemplate.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "CoreApiTemplate.Api.dll"]