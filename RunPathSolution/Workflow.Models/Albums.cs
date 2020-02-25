using System;
using System.Collections.Generic;
using System.Text;
using Workflow.Models.Interfaces;

namespace Workflow.Models
{
    [Serializable]
    public class Albums : IPhotoAlbum
    {
        public List<Photos> Photos { get; set; }
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }


    }
}
