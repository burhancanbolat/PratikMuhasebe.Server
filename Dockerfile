FROM registry.pratikislem.com.tr/pratik-tools/dotnet-image:aspnet-8.0

WORKDIR /app

COPY . .

ENTRYPOINT ["dotnet", "publish/PratikMuhasebe.Server.dll"]
