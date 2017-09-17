namespace _04.Recharge
{
    public class RechargeStation : IRechargeable
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }

        public void Recharge()
        {
            throw new System.NotImplementedException();
        }
    }
}