using INTEGRAÇÃO_SPOTIFY.Interfaces;
using SpotifyAPI.Web;

public class SpotifyDownloader : IDownloader
{
    private readonly SpotifyClient _spotifyClient;

    public SpotifyDownloader()
    {
        var config = SpotifyClientConfig.CreateDefault();
        var request = new ClientCredentialsRequest("2cfd4d14d5ae4dc29bc3ef87862fd1f6", "66fb642069a045c8a320e4620cf9fd74");
        var response = new OAuthClient(config).RequestToken(request).Result;
        _spotifyClient = new SpotifyClient(config.WithToken(response.AccessToken));
    }

    public async Task BaixarMusicasOuPlaylist(string url, YoutubeSearch youtubeSearch)
    {
        if (url.Contains("playlist"))
        {
            await BaixarPlaylistSpotify(url, youtubeSearch);
        }
        else
        {
            await BaixarMusicaSpotify(url, youtubeSearch);
        }
    }

    private async Task BaixarPlaylistSpotify(string url, YoutubeSearch youtubeSearch)
    {
        var playlistId = ExtrairSpotifyId(url);
        var playlist = await _spotifyClient.Playlists.Get(playlistId);

        Console.WriteLine($"Baixando playlist: {playlist.Name}");

        foreach (var item in playlist.Tracks.Items)
        {
            if (item.Track is FullTrack track)
            {
                string query = $"{track.Name} {track.Artists[0].Name}";
                double duracao = track.DurationMs / 1000.0;
                await youtubeSearch.BaixarMusicaYoutube(query, duracao);
            }
        }
    }

    private async Task BaixarMusicaSpotify(string url, YoutubeSearch youtubeSearch)
    {
        var trackId = ExtrairSpotifyId(url);
        var track = await _spotifyClient.Tracks.Get(trackId);

        string query = $"{track.Name} {track.Artists[0].Name}";
        double duracao = track.DurationMs / 1000.0;
        await youtubeSearch.BaixarMusicaYoutube(query, duracao);
    }

    private string ExtrairSpotifyId(string url)
    {
        var uri = new Uri(url);

        if (uri.AbsolutePath.Contains("track") || uri.AbsolutePath.Contains("playlist"))
        {
            var segments = uri.AbsolutePath.Split('/');
            string spotifyId = segments.Last(); 
            return spotifyId.Split('?')[0];    
        }

        throw new ArgumentException("URL inválida.");
    }
}
