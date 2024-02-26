namespace CLED.Artic.Web.Services;

using CLED.Artic.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FakeArtworksService : IArtworksService
{
    public Task<IEnumerable<Artwork>> GetArtworks()
    {
        var list = new List<Artwork>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new Artwork()
            {
                Title = $"Titolo opera {i}",
                Description = $"<p>Descrizione dell'opera {i}</p>"
            });
        }
        return Task.FromResult((IEnumerable<Artwork>)list);
    }
}
