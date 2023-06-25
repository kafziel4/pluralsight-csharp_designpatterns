namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Menu
    {
        public readonly ICupon _coupon;

        public Menu(ICupon coupon)
        {
            _coupon = coupon;
        }

        public abstract int CalculatePrice();
    }

    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class VegetarianMenu : Menu
    {
        public VegetarianMenu(ICupon coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CupounValue;
        }
    }

    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class MeatBasedMenu : Menu
    {
        public MeatBasedMenu(ICupon coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 30 - _coupon.CupounValue;
        }
    }

    /// <summary>
    /// Implementor
    /// </summary>
    public interface ICupon
    {
        int CupounValue { get; }
    }

    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class NoCoupon : ICupon
    {
        public int CupounValue { get => 0; }
    }

    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class OneEuroCoupon : ICupon
    {
        public int CupounValue { get => 1; }
    }
}
