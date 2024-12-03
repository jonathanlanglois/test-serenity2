#!/bin/bash
set -e

echo "Starting post-creation script..."

apt-get update
apt-get install -y curl gnupg
curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add -
curl https://packages.microsoft.com/config/debian/11/prod.list > /etc/apt/sources.list.d/mssql-release.list
apt-get update

ACCEPT_EULA=Y apt-get install -y mssql-tools18 unixodbc-dev

curl -fsSL https://deb.nodesource.com/setup_20.x | bash -
apt-get install -y nodejs
npm install -g npm@latest


apt-get clean

cd test-serenity2.Web
npm ci
dotnet build

dotnet tool install sergen
dotnet tool list sergen

echo "Versions des utilitaires :"
echo "Node.js version: $(node -v)"
echo "npm version: $(npm -v)"
echo "dotnet version: $(dotnet --version)"

echo "Post-creation script completed successfully!"