namespace Portfolio.Models;

/// <summary>
/// Eine Demo-Karte auf der One-Page. Wird aus wwwroot/data/demos.json geladen –
/// neue Demos brauchen nur einen JSON-Eintrag, kein Code-Änderung.
/// Status: "live" | "dev" | "planned".
/// </summary>
public sealed record DemoProject(
    string Id,
    string TitleDe,
    string TitleEn,
    string TitleTr,
    string DescriptionDe,
    string DescriptionEn,
    string DescriptionTr,
    string[] TechStack,
    string Status,
    string? RepoUrl,
    string? LiveUrl,
    string Icon);
