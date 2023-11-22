# Use the official .NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 88
ENV ASPNETCORE_URLS http://+:88

# Use the official .NET Core SDK as a build image
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

# Copy the solution file and restore dependencies
COPY . .
RUN dotnet restore
RUN dotnet test

# Build the application
WORKDIR "/src/GustavoSeguros.Presentation/"
RUN dotnet build "GustavoSeguros.Presentation.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "GustavoSeguros.Presentation.csproj" -c Release -o /app/publish

# Build the final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "GustavoSeguros.Presentation.dll"]