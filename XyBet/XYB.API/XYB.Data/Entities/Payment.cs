namespace XYB.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public AppUser User { get; set; }

        public double Sum { get; set; }

        public Currency Currency { get; set; }

        public double InternalCurrencyEquivalent { get; set; }

        public PaymentType PaymentType { get; set; }
    }
}
