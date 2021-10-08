using System.Collections.Generic;

namespace VendingMachine.Models
{
    public class Machine : IVending
    {
        private List<Product> Products { get; }
        private Sequencer Sequencer { get; }
        private Kron Money { get; }

        public Machine()
        {
            Money = new Kron();
            Sequencer = new Sequencer();
            Products = new List<Product>()
            {
                //Drink
                new Drink(Sequencer.Next(), "Soda", "Drink cool", 5)
                {
                    Adult = false
                },
                new Drink(Sequencer.Next(), "Cocacola", "Energy", 5)
                {
                    Adult = false
                },
                new Drink(Sequencer.Next(), "Fanta", "Energy", 5)
                {
                    Adult = false
                },
                new Drink(Sequencer.Next(), "Cocacola Zero", "Red", 5)
                {
                    Adult = false
                },
                new Drink(Sequencer.Next(), "Pepsi", "delicase", 5)
                {
                    Adult = false
                },
                //Food
                new Food(Sequencer.Next(), "Pizza hot", "Enjoy it", 10)
                {
                    Recipe = "Chocolate"
                },
                new Food(Sequencer.Next(), "Pasta", "Delicase", 10)
                {
                    Recipe = "Chocolate"
                },
                new Food(Sequencer.Next(), "Potato Chips", "Cheez", 10)
                {
                    Recipe = "Chocolate"
                },
                    new Food(Sequencer.Next(), "Burgar", "Meat", 10)
                {
                    Recipe = "Chocolate"
                },
                //Toy
               
                new Toy(Sequencer.Next(), "Bear", "Valantine", 20)
                {
                    Age = 10
                },
                new Toy(Sequencer.Next(), "Ball", "Play Soccer", 20)
                {
                    Age = 14
                },
                new Toy(Sequencer.Next(), "Doll", "Red doll", 20)
                {
                    Age = 14
                },
                new Toy(Sequencer.Next(), "Baloon", "Blue",  20)
                {
                    Age = 10
                },

                new Toy(Sequencer.Next(), "Rattle", "Sound good",  20)
                {
                    Age = 10
                },

                new Toy(Sequencer.Next(), "Logo wall", "Be creative",  20)
                {
                    Age = 10
                }

            };
        }
        public IDictionary<int, int> EndTransaction()
        {
            List<int> denominations = Money.Denominations;
            denominations.Sort();
            denominations.Reverse();

            IDictionary<int, int> result = new Dictionary<int, int>();

            int amount = Money.Amount();
            Money.Clear();

            foreach (int price in denominations)
            {
                if (price < amount)
                {
                    result.Add(price, amount / price);
                    amount -= price * (amount / price);
                    if (amount == 0)
                    {
                        break;
                    }
                }

            }

            return result;
        }

        public void InsertMoney(int money)
        {
            Money.Add(money);
        }

        public Product Purchase(int id)
        {
            Product result = null;
            foreach (Product item in Products)
            {
                if (item.Id == id)
                {
                    result = item;
                    Money.Decrease(item.Price);
                    break;
                }
            }

            return result;
        }

        public List<Product> ShowAll()
        {
            return Products;
        }
    }
}
