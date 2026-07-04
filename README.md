# Portfolio – M. Ali Bayrak · LYKON-TECH

Mehrsprachige Portfolio-One-Page (DE / EN / TR) als **Blazor WebAssembly**-App –
Quellcode bewusst öffentlich als C#-Showcase.

**Live:**
- 🌐 [lykon-tech.de](https://lykon-tech.de) (Hetzner, Hauptdomain)
- 📄 [malibay81.github.io/PORTFOLIO](https://malibay81.github.io/PORTFOLIO/) (GitHub Pages)

> *English: Multilingual portfolio one-pager (German / English / Turkish) built
> with Blazor WebAssembly. The source is intentionally public as a C# showcase.*

## Features

- **One-Page-Aufbau**: Hero mit Typewriter-Effekt, Über mich, Tech-Stack,
  Projekte/Live-Demos, Kontakt – plus Impressum & Datenschutz als Unterseiten
- **Dreisprachig** (Deutsch, Englisch, Türkisch) mit Sprachumschalter,
  Auswahl wird im localStorage gemerkt
- **Berufserfahrung dynamisch**: wird immer ab Karrierestart **2008** berechnet –
  veraltet nie
- **Demo-Karten datengetrieben**: neue Demo = ein Eintrag in
  [`wwwroot/data/demos.json`](src/Portfolio/wwwroot/data/demos.json)
  (Status `live` / `dev` / `planned`, GitHub- und Live-Link)
- **Dark/Light-Mode** (dunkel als Standard) und frei wählbare Akzentfarbe
- **DSGVO-freundlich**: Fonts & Skripte self-hosted, keine Third-Party-Requests,
  keine Cookies, Kontaktformular rein per `mailto`

## Tech-Stack

.NET 10 · Blazor WebAssembly · MudBlazor · CSS (Glassmorphism) · GitHub Actions

## Lokal starten

```bash
dotnet run --project src/Portfolio/Portfolio.csproj
```

## Deployment

`main` ist der einzige Deploy-Branch: Ein GitHub-Actions-Workflow baut die App
bei jedem Push automatisch und veröffentlicht sie auf GitHub Pages sowie auf
einem privaten Server (Details im Workflow:
[`.github/workflows/deploy.yml`](.github/workflows/deploy.yml)).

## Lizenz

[Apache-2.0](LICENSE)
