using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatMasala2
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo); // => filterHandler.Invoke(photo);
        }

        // // 1 - usul
        // public void Process(string path)
        // {
        //  // var photo = new Photo();
        //  var photo = Photo.Load(path);


        // var filters = new PhotoFilters();
        // filters.ApplyBrightness(photo);
        // filters.ApplyContrast(photo);
        // filters.Resize(photo);
        // }
    }
}
