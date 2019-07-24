FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY publish ./

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "AspVue2.dll"]