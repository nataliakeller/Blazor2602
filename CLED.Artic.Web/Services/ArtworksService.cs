namespace CLED.Artic.Web.Services;

using CLED.Artic.Web.Models;

public class ArtworksService : IArtworksService
{
    private readonly HttpClient _httpClient;

    public ArtworksService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Artwork>> GetArtworks()
    {
        await Task.Delay(1000);
        var response = await _httpClient.GetFromJsonAsync<GetArtworksResponse>("https://api.artic.edu/api/v1/artworks");
        if (response is null)
            return [];

        return response.Data;
    }
}
