namespace DelegatMasala2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness; // => new PhotoProcessor.PhotoFilterHandler(filters.ApplyContrast);
            filterHandler += filters.ApplyContrast; // => (PhotoProcessor.PhotoFilterHandler) Delegate.Combine(filterHandler, new PhotoProtcessor.PhotoFilterHandler(filters.ApplyContrast));
            filterHandler += filters.Resize;
            processor.Process("photo.jpg", filterHandler);
        }
    }
}