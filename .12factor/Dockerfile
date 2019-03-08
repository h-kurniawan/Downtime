# Build dotnet core project
FROM mdsol/dotnetcore21-sdk as build

ARG DEBIAN_FRONTEND=noninteractive

# Install system components
RUN apt-get update
RUN apt-get install -y curl gnupg apt-transport-https

# Import the public repository GPG keys
RUN curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add -

# Register the Microsoft Product feed
RUN sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-debian-stretch-prod stretch main" \
> /etc/apt/sources.list.d/microsoft.list'

# Update the list of products
RUN apt-get update

# Install Powershell
RUN apt-get install -y powershell
ENV PowerShellExe=pwsh

# Copy the project into the container
WORKDIR /home/app
COPY . .

# Restore and build projects
RUN nuget-exec ./.12factor/build.sh

# Build runtime container
FROM mdsol/dotnetcore21-aspnetcore-runtime as runtime
WORKDIR /home/app

COPY --from=build /home/app/src/Web/Medidata.Mole.Api/out .
COPY --from=build /home/app/src/Tools/Medidata.Mole.AmpridatvirMigrator/out /home/app/migrate_ampri_task
RUN chown -R app:app /home/app

# Setup and run the app
USER app
WORKDIR /home/app
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENV ASPNETCORE_ENVIRONMENT Production
ENTRYPOINT ["dotnet", "Downtime.dll"]
