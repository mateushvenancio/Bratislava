FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /api

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

RUN dotnet ef database update

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /api
COPY --from=build-env /api/out .

EXPOSE 5000
ENTRYPOINT ["dotnet", "BratislavaApi.dll"]