FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS builder

WORKDIR /app
COPY src /app
RUN dotnet restore Secrets.csproj
RUN dotnet publish --configuration Release --output ./out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
LABEL maintainer "frank@pommerening-online.de"
ENV ASPNETCORE_URLS http://0.0.0.0:5000
EXPOSE 5000
WORKDIR /app/

COPY --from=builder /app/out/* ./

ENV REFRESHED_AT 2019-04-21

ENTRYPOINT ["dotnet", "Secrets.dll"]