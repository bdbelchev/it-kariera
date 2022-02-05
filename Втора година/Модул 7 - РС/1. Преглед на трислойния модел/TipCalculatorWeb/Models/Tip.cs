namespace TipCalculatorWeb.Models
{
    public class Tip
    {
        private decimal percent;

        public Tip(decimal amount, decimal percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        private decimal Amount { get; set; }

        private decimal Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0m;
                }
                else
                {
                    this.percent = value;
                }
            }
        }

        public decimal CalculateTip()
        {
            return Amount * Percent;
        }

        public decimal CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
