namespace CLED.Artic.Web.Services;

using CLED.Artic.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IArtworksService
{
    Task<IEnumerable<Artwork>> GetArtworks();
}