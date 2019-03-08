#!/usr/bin/env bash
# compiles Downtime from its source directory
# requires: Env var $MDSOL_NUGET_ACCESS_TOKEN
set -eo pipefail

dotnet restore --source https://api.nuget.org/v3/index.json \
  --source https://imedidata.myget.org/F/mdsol/auth/$MDSOL_NUGET_ACCESS_TOKEN/api/v3/index.json
dotnet publish /home/app/src/Downtime/Downtime.csproj -c Release -o out
