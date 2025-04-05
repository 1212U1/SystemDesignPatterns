namespace StatePattern
{
    public class DirectionService
    {
        private ITransportationMode transportationMode;
        public DirectionService(ITransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }
        public void ChangeTransportationMode(ITransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }
        public Int32 GetETA()
        {
            return this.transportationMode.GetETA();
        }
        public void GetDirection()
        {
            this.transportationMode.GetDirection();
        }
    }
}
