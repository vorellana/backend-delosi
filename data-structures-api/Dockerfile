# Imagen base
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR webapp

# Puertos
EXPOSE 80
EXPOSE 5024

# Copia csproj y restaura dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia todo lo demás y construye
COPY . ./
RUN dotnet publish -c Release -o out

# Genera imagen de runtime
FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /webapp
COPY --from=build /webapp/out .

# Comando de inicio
ENTRYPOINT ["dotnet", "data-structures-api.dll"]
