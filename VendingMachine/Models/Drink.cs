namespace VendingMachine.Models
{
    public class Drink : Product
    {
        private string _message;
        public Drink(int id, string name, string message, int price) : base(id, name, price)
        {
            _message = message;
        }

        public bool Adult { get; set; }

        public override string Examine()
        {
            return base.Examine();
        }

        public override string Use()
        {
            return _message;
        }
    }
}
