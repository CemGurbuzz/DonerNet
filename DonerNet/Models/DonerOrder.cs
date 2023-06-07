namespace DonerNet.Models
{
    public class DonerOrder
    {
        public int Id { get; set; }
        public string DonerName { get; set; }
        public float BasePrice { get; set; }
        public DateTime OrderDateTime { get; set; }

    }
}
