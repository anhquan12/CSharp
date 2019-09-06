namespace Practicle
{
    public class Book : Product
    {
        public override double computeTax()
        {
            var tax = (price * 8) / 100;
            return tax;
        }
    }
}