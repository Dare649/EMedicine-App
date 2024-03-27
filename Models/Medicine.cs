namespace EMedicineBE.Models
{
    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public string Manufacturer {  get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
        public int MedicineId { get; set; }
        public string Type { get; set; }
    }
}
