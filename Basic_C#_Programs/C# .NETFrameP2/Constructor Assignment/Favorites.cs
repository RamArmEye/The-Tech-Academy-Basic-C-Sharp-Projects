using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor_Assignment

    {
        // The Chain class demonstrates constructor chaining with two string properties.
        public class Chain
    
        
        {
            // This constructor takes one parameter for the user's favorite car.
            // It chains to the two-parameter constructor, using a default state of "California".
            public Chain(string car) : this(car, "California")
            {
                Console.WriteLine(car + " and your default favorite state is " + FavoriteState);
            }

            // This constructor takes one parameter for the user's favorite state,
            // plus a boolean to differentiate its signature from the other single-parameter constructor.
            // It chains to the two-parameter constructor, using a default car of "Toyota".
            public Chain(bool isState, string state) : this("Toyota", state)
            {
                Console.WriteLine(state + " and your default favorite car is " + FavoriteCar);
            }

            // This constructor takes both a favorite car and a favorite state.
            // It is called by the other constructors via "this(...)".
            public Chain(string car, string state)
            {
                FavoriteCar = car;
                FavoriteState = state;
            }

            // Property to store the user's favorite car.
            private string FavoriteCar { get; set; }

            // Property to store the user's favorite U.S. state.
            private string FavoriteState { get; set; }
        }
    }