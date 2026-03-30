FROM mcr.microsoft.com/dotnet/sdk:10.0 AS built
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=built /app/out ./
EXPOSE 5000
ENTRYPOINT ["dotnet", "ContainerLab.Api.dll"]