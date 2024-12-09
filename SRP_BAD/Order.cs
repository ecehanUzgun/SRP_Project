namespace SRP_BAD
{
    public class Order
    {
        public int ID { get; set; }
        public string ShipAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public void CreateOrder(Order order)
        {
            // Siparişi veritabanına kayıt işlemi
        }

        public void GenerateInvoice()
        {
            // Sipariş bilgileri kullanılarak fatura oluşturma işlemi
        }

        public void SendOrderReceivedEmail()
        {
            // Siparişin alındığına dair e-posta gönderme işlemi
        }
    }
}
