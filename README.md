# wozu-lesson8-activities1-2

# Interfaces Activity

Given the interface Area below, create a public Rectangle class that implements the interface. For the Rectangle class you will need:

Two double properties, height and width.

A constructor that accepts values for its two properties. The first parameter should be for height.

```
namespace Exercise {
    public interface Area {
        double GetArea();
    }
}
```

# Problem 2 

Given the interface Drawable below, create a public Deck class that implements the interface. For the Deck class you will need:

A property that is a List of strings. This collection will represent the playing cards of the deck. Use whatever variable name you'd like.

A constructor with a single parameter for setting the list of cards.

In the Drawable interface below, the GetTopCard method expects the implementation to get the first item. You can use the First() method of the List object to get the first item in the list: e.g. myList.First().

```
namespace Exercise {
    public interface Drawable {
        string GetTopCard();
    }
}
```
