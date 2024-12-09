namespace SRP_Validate
{
    public class Order
    {
        // Her siparişte olması gereken özellikleri barındırır.
        public int ID { get; set; }
        public string ShipAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
