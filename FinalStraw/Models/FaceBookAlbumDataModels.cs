using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalStraw.Models
{
    public class FaceBookAlbumDataModels
    {
        public List<FaceBookAlbum> Data { get; set; }
    }
    public class FaceBookAlbum
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<FaceBookImage> Images { get; set; }
    }

    public class FaceBookImageData
    {
        public List<FaceBookImage> Data { get; set; }
    }

    public class FaceBookImage
    {
        public string Id { get; set; }
        public string Picture { get; set; }
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}