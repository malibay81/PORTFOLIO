namespace Portfolio.Services;

public class TranslationService
{
    private string _currentLanguage = "de";
    public event Action? OnLanguageChanged;

    public string CurrentLanguage => _currentLanguage;

    public IReadOnlyList<(string Code, string Label, string Flag)> Languages { get; } =
    [
        ("de", "Deutsch", "🇩🇪"),
        ("en", "English", "🇬🇧"),
        ("tr", "Türkçe",  "🇹🇷")
    ];

    private readonly Dictionary<string, Dictionary<string, string>> _translations = new()
    {
        // ── DEUTSCH ───────────────────────────────────────────────
        ["de"] = new()
        {
            // Banner
            ["banner.construction"] = "Im Aufbau",

            // Navigation
            ["nav.home"]        = "Startseite",
            ["nav.about"]       = "Über mich",
            ["nav.projects"]    = "Projekte",
            ["nav.demos"]       = "Live-Demos",
            ["nav.contact"]     = "Kontakt",

            // Hero
            ["hero.greeting"]       = "Hallo, ich bin",
            ["hero.name"]           = "M. Ali Bayrak",
            ["hero.title"]          = "Software-Ingenieur & .NET Spezialist",
            ["hero.subtitle"]       = "{years}+ Jahre Erfahrung im Sondermaschinenbau, Automotive und industrienaher Softwareentwicklung.",
            ["hero.cta.projects"]   = "Meine Projekte",
            ["hero.cta.contact"]    = "Kontakt aufnehmen",

            // About
            ["about.title"]     = "Über mich",
            ["about.lead"]      = "Dipl.-Ing. (FH) Mechatronik mit tiefer Leidenschaft für saubere, wartbare Software.",
            ["about.body"]      = "Seit 2008 entwickle ich Softwarelösungen für anspruchsvolle Industrieprojekte. Mein Fokus liegt auf C# / .NET, WPF, Blazor sowie der Integration von SPS-Systemen (Siemens, Beckhoff) und Messtechnik-Werkzeugen (Vector CANoe/CANape).",
            ["about.available"] = "Verfügbar für nebenberufliche Projekte",

            // Skills
            ["skills.title"]    = "Technologien",

            // Projects
            ["projects.title"]  = "Projekte",
            ["projects.demo"]   = "Live-Demo",
            ["projects.code"]   = "Quellcode",

            // Demos
            ["demos.title"]           = "Live-Demos",
            ["demos.telemetry.title"] = "Telemetrie-Dashboard",
            ["demos.telemetry.desc"]  = "Echtzeit-Simulation von Industriemessdaten mit interaktiven Diagrammen und CSV-Export.",

            // Contact
            ["contact.title"]         = "Kontakt",
            ["contact.headline"]      = "Lass uns zusammenarbeiten",
            ["contact.subline"]       = "Ich bin offen für spannende Projekte und freiberufliche Anfragen. Schreib mir einfach!",
            ["contact.intro"]         = "Interessiert an einer Zusammenarbeit? Ich freue mich auf Ihre Nachricht.",
            ["contact.email"]         = "E-Mail",
            ["contact.linkedin"]      = "LinkedIn",
            ["contact.github"]        = "GitHub",
            ["contact.direct"]        = "Direktkontakt",
            ["contact.availability"]  = "Verfügbarkeit",
            ["contact.avail.yes"]     = "Verfügbar",
            ["contact.avail.no"]      = "Ausstehend",
            ["contact.remote"]        = "Remote & vor Ort im Raum NRW möglich.",
            ["contact.profiles"]      = "Profile & Plattformen",
            ["contact.form.title"]    = "Nachricht senden",
            ["contact.form.name"]     = "Ihr Name *",
            ["contact.form.company"]  = "Unternehmen",
            ["contact.form.email"]    = "E-Mail-Adresse *",
            ["contact.form.type"]     = "Anfragetyp",
            ["contact.form.subject"]  = "Betreff *",
            ["contact.form.message"]  = "Ihre Nachricht *",
            ["contact.form.privacy"]  = "Ich stimme der Verarbeitung meiner Daten zur Kontaktaufnahme zu.",
            ["contact.form.send"]     = "Nachricht senden",
            ["contact.form.sending"]  = "Wird gesendet…",
            ["contact.form.sent"]     = "Nachricht vorbereitet!",
            ["contact.form.required"] = "Pflichtfeld",
            ["contact.form.hint"]     = "Das Formular öffnet Ihren E-Mail-Client. Es werden keine Daten auf einem Server gespeichert.",

            // Footer
            ["demos.subtitle"]        = "Jede Demo ist ein eigenständiges Open-Source-Projekt auf GitHub. Server-Apps laufen live auf eigener Subdomain.",
            ["demos.status.live"]     = "Live",
            ["demos.status.dev"]      = "In Neuentwicklung",
            ["demos.status.planned"]  = "Geplant",
            ["demos.repo"]            = "Quellcode",
            ["demos.open"]            = "Live öffnen",

            // Footer
            ["footer.rights"]   = "Alle Rechte vorbehalten."
        },

        // ── ENGLISH ───────────────────────────────────────────────
        ["en"] = new()
        {
            // Banner
            ["banner.construction"] = "Under Construction",

            ["nav.home"]        = "Home",
            ["nav.about"]       = "About",
            ["nav.projects"]    = "Projects",
            ["nav.demos"]       = "Live Demos",
            ["nav.contact"]     = "Contact",

            ["hero.greeting"]       = "Hi, I'm",
            ["hero.name"]           = "M. Ali Bayrak",
            ["hero.title"]          = "Software Engineer & .NET Specialist",
            ["hero.subtitle"]       = "{years}+ years of experience in special-purpose machinery, automotive, and industrial software development.",
            ["hero.cta.projects"]   = "My Projects",
            ["hero.cta.contact"]    = "Get in Touch",

            ["about.title"]     = "About Me",
            ["about.lead"]      = "Dipl.-Eng. (FH) Mechatronics with a deep passion for clean, maintainable software.",
            ["about.body"]      = "Since 2008, I have been developing software solutions for demanding industrial projects. My focus is on C# / .NET, WPF, Blazor, and the integration of PLC systems (Siemens, Beckhoff) and measurement tools (Vector CANoe/CANape).",
            ["about.available"] = "Available for freelance projects",

            ["skills.title"]    = "Technologies",

            ["projects.title"]  = "Projects",
            ["projects.demo"]   = "Live Demo",
            ["projects.code"]   = "Source Code",

            ["demos.title"]           = "Live Demos",
            ["demos.telemetry.title"] = "Telemetry Dashboard",
            ["demos.telemetry.desc"]  = "Real-time simulation of industrial measurement data with interactive charts and CSV export.",

            ["contact.title"]         = "Contact",
            ["contact.headline"]      = "Let's Work Together",
            ["contact.subline"]       = "I'm open to exciting projects and freelance inquiries. Just drop me a message!",
            ["contact.intro"]         = "Interested in working together? I look forward to hearing from you.",
            ["contact.email"]         = "Email",
            ["contact.linkedin"]      = "LinkedIn",
            ["contact.github"]        = "GitHub",
            ["contact.direct"]        = "Direct Contact",
            ["contact.availability"]  = "Availability",
            ["contact.avail.yes"]     = "Available",
            ["contact.avail.no"]      = "Pending",
            ["contact.remote"]        = "Remote & on-site in the NRW region possible.",
            ["contact.profiles"]      = "Profiles & Platforms",
            ["contact.form.title"]    = "Send a Message",
            ["contact.form.name"]     = "Your Name *",
            ["contact.form.company"]  = "Company",
            ["contact.form.email"]    = "Email Address *",
            ["contact.form.type"]     = "Inquiry Type",
            ["contact.form.subject"]  = "Subject *",
            ["contact.form.message"]  = "Your Message *",
            ["contact.form.privacy"]  = "I agree to the processing of my data for contact purposes.",
            ["contact.form.send"]     = "Send Message",
            ["contact.form.sending"]  = "Sending…",
            ["contact.form.sent"]     = "Message prepared!",
            ["contact.form.required"] = "Required field",
            ["contact.form.hint"]     = "The form opens your email client. No data is stored on a server.",

            ["demos.subtitle"]        = "Each demo is a standalone open-source project on GitHub. Server apps run live on their own subdomain.",
            ["demos.status.live"]     = "Live",
            ["demos.status.dev"]      = "Being rebuilt",
            ["demos.status.planned"]  = "Planned",
            ["demos.repo"]            = "Source Code",
            ["demos.open"]            = "Open Live",

            ["footer.rights"]   = "All rights reserved."
        },

        // ── TÜRKÇE ────────────────────────────────────────────────
        ["tr"] = new()
        {
            // Banner
            ["banner.construction"] = "Yapım Aşamasında",

            ["nav.home"]        = "Ana Sayfa",
            ["nav.about"]       = "Hakkımda",
            ["nav.projects"]    = "Projeler",
            ["nav.demos"]       = "Canlı Demolar",
            ["nav.contact"]     = "İletişim",

            ["hero.greeting"]       = "Merhaba, ben",
            ["hero.name"]           = "M. Ali Bayrak",
            ["hero.title"]          = "Yazılım Mühendisi & .NET Uzmanı",
            ["hero.subtitle"]       = "Özel makine, otomotiv ve endüstriyel yazılım geliştirme alanında {years}+ yıl deneyim.",
            ["hero.cta.projects"]   = "Projelerim",
            ["hero.cta.contact"]    = "İletişime Geç",

            ["about.title"]     = "Hakkımda",
            ["about.lead"]      = "Mekatronik Dipl.-Müh. (FH) — temiz ve sürdürülebilir yazılıma derin bir tutku ile.",
            ["about.body"]      = "2008'den beri zorlu endüstriyel projeler için yazılım çözümleri geliştiriyorum. Odak noktam C# / .NET, WPF, Blazor ve PLC sistemleri (Siemens, Beckhoff) ile ölçüm araçlarının (Vector CANoe/CANape) entegrasyonudur.",
            ["about.available"] = "Serbest projeler için müsaitim",

            ["skills.title"]    = "Teknolojiler",

            ["projects.title"]  = "Projeler",
            ["projects.demo"]   = "Canlı Demo",
            ["projects.code"]   = "Kaynak Kod",

            ["demos.title"]           = "Canlı Demolar",
            ["demos.telemetry.title"] = "Telemetri Panosu",
            ["demos.telemetry.desc"]  = "İnteraktif grafikler ve CSV dışa aktarımı ile endüstriyel ölçüm verilerinin gerçek zamanlı simülasyonu.",

            ["contact.title"]         = "İletişim",
            ["contact.headline"]      = "Birlikte Çalışalım",
            ["contact.subline"]       = "Heyecan verici projeler ve serbest çalışma teklifleri için açığım. Bana yazmaktan çekinmeyin!",
            ["contact.intro"]         = "Birlikte çalışmak ister misiniz? Mesajınızı bekliyorum.",
            ["contact.email"]         = "E-posta",
            ["contact.linkedin"]      = "LinkedIn",
            ["contact.github"]        = "GitHub",
            ["contact.direct"]        = "Doğrudan İletişim",
            ["contact.availability"]  = "Müsaitlik",
            ["contact.avail.yes"]     = "Müsait",
            ["contact.avail.no"]      = "Onay Bekleniyor",
            ["contact.remote"]        = "Uzaktan ve NRW bölgesinde yüz yüze çalışma mümkün.",
            ["contact.profiles"]      = "Profiller & Platformlar",
            ["contact.form.title"]    = "Mesaj Gönder",
            ["contact.form.name"]     = "Adınız *",
            ["contact.form.company"]  = "Şirket",
            ["contact.form.email"]    = "E-posta Adresi *",
            ["contact.form.type"]     = "Talep Türü",
            ["contact.form.subject"]  = "Konu *",
            ["contact.form.message"]  = "Mesajınız *",
            ["contact.form.privacy"]  = "İletişim amacıyla verilerimin işlenmesini kabul ediyorum.",
            ["contact.form.send"]     = "Mesaj Gönder",
            ["contact.form.sending"]  = "Gönderiliyor…",
            ["contact.form.sent"]     = "Mesaj hazırlandı!",
            ["contact.form.required"] = "Zorunlu alan",
            ["contact.form.hint"]     = "Form e-posta istemcinizi açar. Hiçbir veri sunucuda saklanmaz.",

            ["demos.subtitle"]        = "Her demo, GitHub üzerinde bağımsız bir açık kaynak projesidir. Sunucu uygulamaları kendi alt alan adlarında canlı çalışır.",
            ["demos.status.live"]     = "Canlı",
            ["demos.status.dev"]      = "Yeniden geliştiriliyor",
            ["demos.status.planned"]  = "Planlandı",
            ["demos.repo"]            = "Kaynak Kod",
            ["demos.open"]            = "Canlı Aç",

            ["footer.rights"]   = "Tüm hakları saklıdır."
        }
    };

    public string this[string key]
    {
        get
        {
            if (_translations.TryGetValue(_currentLanguage, out var dict) &&
                dict.TryGetValue(key, out var value))
                return value;

            // Fallback to German
            if (_translations.TryGetValue("de", out var fallback) &&
                fallback.TryGetValue(key, out var fallbackValue))
                return fallbackValue;

            return $"[{key}]";
        }
    }

    public void SetLanguage(string code)
    {
        if (_currentLanguage == code) return;
        _currentLanguage = code;
        OnLanguageChanged?.Invoke();
    }
}
