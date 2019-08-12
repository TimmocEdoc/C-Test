namespace test
{
    public class Product
    {
        private string id;
        private string name;
        private int price;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public Product(string id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}