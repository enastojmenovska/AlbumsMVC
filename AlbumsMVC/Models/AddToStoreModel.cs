using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumsMVC.Models
{
    public class AddToStoreModel
    {
        public int storeId { get; set; }
        public int albumId { get; set; }
        public List<Album> albums { get; set; }
        public Store store { get; set; }
        public AddToStoreModel()
        {
            albums = new List<Album>();
        }
    }
}