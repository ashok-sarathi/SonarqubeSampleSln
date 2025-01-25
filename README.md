# SonarqubeSample

### [Referance](https://docs.sonarsource.com/sonarqube-server/latest/analyzing-source-code/test-coverage/dotnet-test-coverage/#dotnetcoverage)

### Need
- Docker Desktop
- Docker Sonarqube
- Sonarqube Project Id: `<sonar-project-key>`
- Sonarqube Token: `<sonar-token>`
- Dotnet with Unit test [Repo](https://github.com/ashok-sarathi/SonarqubeSampleSln.git)

```sh
dotnet sonarscanner begin /k:"<sonar-project-key>" /d:sonar.host.url="http://localhost:32768" /d:sonar.token="<sonar-token>" /d:sonar.cs.vscoveragexml.reportsPaths="coverage.xml"
dotnet build --no-incremental
dotnet-coverage collect dotnet test -f xml -o coverage.xml
dotnet sonarscanner end /d:sonar.token="<sonar-token>"
```
