# Cake

Cake (C# Make) is a build automation system with a C# DSL to do things like compiling code, copy files/folders, running unit tests, compress files and build NuGet packages.

## Continuous integration

| Build server                | Platform      | Build status                                                                                                                                                        | Integration tests                                                                                                                                                   |
|-----------------------------|---------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Azure Pipelines             | MacOS         | [![Azure Pipelines Mac Build status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Mac?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=4) | |
| Azure Pipelines             | Windows       | [![Azure Pipelines Windows Build status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Windows?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=1) | |
| Azure Pipelines             | Debian        | [![Azure Pipelines Debian Build status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Debian%20Stretch?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=7) | |
| Azure Pipelines             | Fedora        | [![Azure Pipelines Fedora Build status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Fedora%2028?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=6) | |
| Azure Pipelines             | Centos        | [![Azure Pipelines Cake Centos status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Centos%207?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=5) | |
| Azure Pipelines             | Ubuntu        | [![Azure Pipelines Ubuntu Build status](https://dev.azure.com/cake-build/Cake/_apis/build/status/Azure%20Pipelines%20-%20Build%20Cake%20Ubuntu?&branchName=develop)](https://dev.azure.com/cake-build/Cake/_build/latest?definitionId=3) | |
| AppVeyor                    | Windows       | [![AppVeyor branch](https://img.shields.io/appveyor/ci/cakebuild/cake/develop.svg)](https://ci.appveyor.com/project/cakebuild/cake/branch/develop)                  | [![AppVeyor branch](https://img.shields.io/appveyor/ci/cakebuild/cake-eijwj/develop.svg)](https://ci.appveyor.com/project/cakebuild/cake-eijwj)  |
| TeamCity                    | Windows       | [![TeamCity Build Status](http://img.shields.io/teamcity/codebetter/Cake_CakeMaster.svg)](http://teamcity.codebetter.com/viewType.html?buildTypeId=Cake_CakeMaster) |                                                                                                                                                                     |
| Bitrise                     | MacOS         | [![Build Status](https://app.bitrise.io/app/42eaef77e8db4a5c/status.svg?token=EDjHGK5njNJ-MrhSbvKM1w&branch=develop)](https://app.bitrise.io/app/42eaef77e8db4a5c)  | ![Build Status](https://app.bitrise.io/app/804b431c1f27e0a0/status.svg?token=qKosHEaJAJEqzZcq4s5WRg&branch=develop)                                                        |
| Bitrise                     | Debian         | [![Build Status](https://app.bitrise.io/app/ea0c6b3c61eb1e79/status.svg?token=KJqOWXllYXz3WYqcB861Uw&branch=develop)](https://app.bitrise.io/app/ea0c6b3c61eb1e79)  | ![Build Status](https://app.bitrise.io/app/5a406f34f22113c6/status.svg?token=TQPbsmA9yP-iJOhzunIP4w&branch=develop)                                                        |
| Bitbucket Pipelines         | Debian         | [![Build Status](https://cakebitbucketpipelinesshield.azurewebsites.net/status/cakebuild/cake-integration-tests/develop)](https://cakebitbucketpipelinesshield.azurewebsites.net/url/cakebuild/cake-integration-tests/develop) |  |
| GitLab                      | Debian      | [![pipeline status](https://gitlab.com/cake-build/cake/badges/develop/pipeline.svg)](https://gitlab.com/cake-build/cake/commits/develop) |  &nbsp;                                                                                                                                                             |
| GitHub Actions              | Windows / Ubuntu/ macOS | [![Build Status](https://github.com/cake-build/cake/workflows/Build/badge.svg?branch=develop)](https://github.com/cake-build/cake/actions) | &nbsp; |

## Code Coverage

[![Coverage Status](https://coveralls.io/repos/github/cake-build/cake/badge.svg?branch=develop)](https://coveralls.io/github/cake-build/cake?branch=develop)

## Documentation

You can read the latest documentation at [https://cakebuild.net/](https://cakebuild.net/).

For a simple example to get started see [Setting up a new project](https://cakebuild.net/docs/getting-started/setting-up-a-new-scripting-project).

## License

Cake is provided as-is under the MIT license. For more information see [LICENSE](https://github.com/cake-build/cake/blob/develop/LICENSE).
