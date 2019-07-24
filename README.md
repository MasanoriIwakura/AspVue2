# AspVue2

[![CircleCI](https://circleci.com/gh/MasanoriIwakura/AspVue2.svg?style=svg)](https://circleci.com/gh/MasanoriIwakura/AspVue2)

## Project setup

```bash
npm install
```

### Compiles and hot-reloads for development

```bash
npm run serve
```

### Compiles and minifies for production

```bash
npm run build
```

### Run your tests

```bash
npm run test
```

### Lints and fixes files

```bash
npm run lint
```

### Customize configuration

See [Configuration Reference](https://cli.vuejs.org/config/).

---

### .NET Core Build

```bash
dotnet build
```

### .NET Core Run

```bash
# 先にnpm run buildをしておく
dotnet run
```

---

## マイグレーション

### データベースの作成

■前提条件

- .NET Core 2.X
- Microsoft.EntityFrameworkCore.Design

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
