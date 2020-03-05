FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
EXPOSE 80 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY AcmeCorp.Web.csproj .
RUN dotnet restore AcmeCorp.Web.csproj
COPY . .
RUN dotnet build AcmeCorp.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AcmeCorp.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet","AcmeCorp.Web.dll"]

