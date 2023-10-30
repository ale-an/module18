namespace Module18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_18_1_1();
            Task_18_1_6();
        }

        private static void Task_18_1_1()
        {
            var carPlant = new CarPlant();

            var scooterConveyor = new ScooterConveyor();
            var carConveyor = new CarConveyor();
            var motoConveyor = new MotoConveyor();

            carPlant.Construct(scooterConveyor);
            carPlant.Construct(carConveyor);
            carPlant.Construct(motoConveyor);

            scooterConveyor.Product.Show();
            carConveyor.Product.Show();
            motoConveyor.Product.Show();
        }

        private static void Task_18_1_6()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
}