using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public interface Area
    {
        double GetArea();
    }

    public class Rectangle : Area
    {
        double height, weight;

        public Rectangle(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public double GetArea()
        {
            return height * weight;
        }
    }
}

namespace Problem2
{
    public interface Drawable
    {
        string GetTopCard();
    }

    public class Deck : Drawable
    {
        List<string> Cards = new List<string>();
        public Deck(List<string> cards)
        {
            this.Cards = cards;
        }

        public string GetTopCard()
        {
            return Cards.First();
        }
    }
}