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

`main` ist der einzige Deploy-Branch. Der Workflow
[`.github/workflows/deploy.yml`](.github/workflows/deploy.yml) baut die App
einmal und deployt sie bei jedem Push auf `main` an **zwei Ziele**:

| Ziel | Pfad | Mechanik |
|---|---|---|
| GitHub Pages | `/PORTFOLIO/` (Unterpfad) | `actions/deploy-pages`, `<base href>` wird umgeschrieben |
| Hetzner-Server | `/` unter `lykon-tech.de` | rsync per SSH nach `/var/www/portfolio`, Caddy liefert statisch aus |

### Einmalige Einrichtung

1. **GitHub Pages** aktivieren: Repo → Settings → Pages → Source = *GitHub Actions*.
2. **Secrets** für das Hetzner-Deployment (Repo → Settings → Secrets → Actions);
   solange sie fehlen, wird der Hetzner-Schritt einfach übersprungen:
   - `HETZNER_HOST` – Server-IP oder Domain
   - `HETZNER_USER` – Deploy-User (z. B. `deploy`)
   - `HETZNER_SSH_KEY` – privater Deploy-SSH-Key (separater Key, nicht der persönliche)
3. **Caddy** auf dem Server: `lykon-tech.de` mit `root /srv/portfolio` +
   `file_server` (siehe Caddyfile im [COCKPIT-Repo](https://github.com/malibay81/COCKPIT),
   das den gemeinsamen Reverse-Proxy stellt).

### SPA-Routing auf GitHub Pages

`404.html` leitet tiefe Links (z. B. `/impressum`) per Query-Parameter auf
`index.html` um; die ursprüngliche URL wird dort über die History-API
wiederhergestellt. Auf dem Hetzner-Server übernimmt Caddy das direkt via
`try_files {path} /index.html`.

## Lizenz

[Apache-2.0](LICENSE)
