using System.Collections.Generic;

namespace PlexRequests.Services.Models
{
    public class PlexTvShow
    {
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public string ProviderId { get; set; }
        public List<string> ShareLabels { get; set; }
    }
}
