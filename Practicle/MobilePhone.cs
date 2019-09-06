namespace Practicle
{
    public class MobilePhone : Product
    {
        public override double computeTax()
        {
            var tax = (price * 10) / 100;
            return tax;
        }
    }
}