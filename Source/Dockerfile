FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine3.15 AS build-env
WORKDIR /app

VOLUME [ "/app/config" ]

COPY Source/ ./Source/

WORKDIR /app/Source

RUN dotnet restore --runtime alpine-x64

RUN dotnet publish -c Release -o out --no-restore 

FROM mcr.microsoft.com/dotnet/runtime:5.0-alpine3.15
WORKDIR /app
COPY --from=build-env /app/Source/out ./

RUN adduser -Ds /bin/sh moduleuser	
USER moduleuser

ENTRYPOINT ["dotnet", "RaaLabs.Edge.ModuleTemplate.dll"]
