# System MongoDB Models

![Build Status Badge](.badges/build-status.svg) ![Build Number Badge](.badges/build-number.svg) ![Coverage](.badges/code-coverage.svg)

## Overview

Concrete implementation of the base document found in TeqBench.System.Data.NoSql.Models for MongoDB.

## Contents
- [Developer Environment Setup](#Developer+Environment+Setup)
- [Usage](#Usage)
- [License](#License)

## Developer Environment Setup

### General
- [Branching Strategy & Practices](https://github.com/teqbench/teqbench.docs/wiki/Branching-Strategy)

### .NET
- [General Tooling](https://github.com/teqbench/teqbench.docs/wiki/.NET-General-Tooling)
- [Configurations](https://github.com/teqbench/teqbench.docs/wiki/.NET-Configuration-Standards)
- [Coding Standards](https://github.com/teqbench/teqbench.docs/wiki/.NET-Coding-Standards)
- [Solutions](https://github.com/teqbench/teqbench.docs/wiki/.NET-Solutions)
- [Projects](https://github.com/teqbench/teqbench.docs/wiki/.NET-Projects)
- [Building](https://github.com/teqbench/teqbench.docs/wiki/.NET-Build-Process)
- [Package & Deployment](https://github.com/teqbench/teqbench.docs/wiki/.NET-Package-Deploy)
- [Versioning](https://github.com/teqbench/teqbench.docs/wiki/.NET-Versioning-Standards)

## Usage

### Add NuGet Package To Project

```
dotnet add package TeqBench.System.Data.NoSql.MongoDB.Models
```

### Update Source Code

> [!NOTE]
> For complete usage, see [TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Models](https://github.com/teqbench/tradingtoolbox.trading.modeler.data.nosql.mongodb.models)

```csharp
using TeqBench.System.Data.NoSql.MongoDB.Models;

namespace TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Models
{
/// <summary>
/// Position model document implementation.
/// </summary>
[BsonCollection("position-models")]
public class PositionModelDocument : Document
{
    // NOTE: Use the BsonCollection attribute to define the name of the collection and the class
    // inherits the Document class for the underlying behaviors.
}
```

## Licensing

[License](https://github.com/teqbench/teqbench.docs/wiki/License)
