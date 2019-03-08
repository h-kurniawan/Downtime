#!/usr/bin/env bash
# compiles Downtime from its source directory
set -eo pipefail

dotnet restore --source https://api.nuget.org/v3/index.json
dotnet publish /home/app/src/Downtime/Downtime.csproj -c Release -o out
