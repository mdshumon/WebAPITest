using System;
using Workflow.Models.Interfaces;

namespace Workflow.Models
{
    [Serializable]
    public class Photos : IPhotoAlbum
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

        public Albums Album { get; set; }

    }
}
