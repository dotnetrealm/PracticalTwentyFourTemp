# PracticalTwentyFour

Repository design pattern

## Setup

- Add connection string in the user secrets file of PracticalTwentyFour.API Project

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=[DBSOURCENAME];Initial Catalog=DesignPatternDB;Persist Security Info=True;User ID=[YOURUSERID];Password=[******];TrustServerCertificate=True"
  }
}
```

> **_NOTE:_** This configuration only works under "Development" enviorment.

## Migration

- Make sure you add connection string in secrets and then follow the following steps
- In the package manager console select "racticalTwentyFour.Data" project and then run the given command

```bash
Update-Database
```
