using System.Net.Http.Json;
using Portfolio.Models;

namespace Portfolio.Services;

public class DemoProjectService(HttpClient http)
{
    private DemoProject[]? _cache;

    public async Task<IReadOnlyList<DemoProject>> GetAllAsync()
    {
        _cache ??= await http.GetFromJsonAsync<DemoProject[]>("data/demos.json") ?? [];
        return _cache;
    }
}
