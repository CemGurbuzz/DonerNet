namespace DonerNet.Models
{
    public class DonersModel
    {
        public string ImageTitle { get; set; }
        public string DonerName { get; set; }
        public float BasePrice { get; set; }
        public bool Beef { get; set; }
        public bool Chicken { get; set; }
        public bool Durum { get; set; }
        public bool Tombik { get; set; }
        public bool Portion { get; set; }
        public bool Sauce { get; set; }
        public bool Onion { get; set; }
        public bool Tomato { get; set; }
        public bool Pickle { get; set; }
        public bool Tahin { get; set; }
        public bool Yogurt { get; set; }
        public bool PotatoFries { get; set; }
        public bool OnionRing { get; set; }
        public bool Cola { get; set; }
        public bool Ayran { get; set; }
        public bool Soda { get; set; }
        public bool Water { get; set; }

        public int Quantity { get; set; }

        public float FinalPrice { get; set; }
    }
}
