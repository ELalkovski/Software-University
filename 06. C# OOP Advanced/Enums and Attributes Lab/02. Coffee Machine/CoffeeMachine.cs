using System;
using System.Collections;
using System.Collections.Generic;

public class CoffeeMachine : IEnumerable<CoffeeType>
{
    private List<CoffeeType> coffeesSold;
    private int coins;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
        this.coins = 0;
    }

    public IList<CoffeeType> CoffeesSold { get { return this.coffeesSold.AsReadOnly(); } }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffeeType;
        Enum.TryParse(type, out coffeeType);

        CoffeePrice coffee;
        Enum.TryParse(size, out coffee);

        if (coins >= (int)coffee)
        {
            coffeesSold.Add(coffeeType);
            coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin insertedCoin;
        Enum.TryParse(coin, out insertedCoin);
        this.coins += (int)insertedCoin;
    }

    public IEnumerator<CoffeeType> GetEnumerator()
    {
        for (int i = 0; i < this.coffeesSold.Count; i++)
        {
            yield return coffeesSold[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
