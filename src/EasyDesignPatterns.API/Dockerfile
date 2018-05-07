FROM microsoft/aspnetcore-build AS builder
WORKDIR /source
COPY . .
RUN dotnet restore -v q && cd src/EasyDesignPatterns.API && dotnet publish --no-restore -v q --output /app/

FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=builder /app .
ENTRYPOINT ["dotnet", "EasyDesignPatterns.API.dll"]