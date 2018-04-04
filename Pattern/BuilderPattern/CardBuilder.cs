namespace BuilderPattern
{
    public class CardBuilder
    {
        Car car = null;

        public void Step1()
        {
            car = new Car();
        }

        public void Step2()
        {
            car.AddParts();
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
