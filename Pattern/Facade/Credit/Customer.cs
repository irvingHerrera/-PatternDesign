namespace Facade.Credit
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
           get { return name; }
        }
    }
}
