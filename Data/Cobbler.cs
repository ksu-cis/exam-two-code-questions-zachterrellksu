using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    /// <summary>
    /// Data for the Cobbler IOrderItem
    /// </summary>
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {

        private FruitFilling fruit;
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get
            {
                return fruit;
            }
            set
            {
                fruit = value;
                NotifyOfPropertyChange("Fruit");
            }
        }

        /// <summary>
        /// Gets if the flavor is Blueberry
        /// </summary>
        public bool BlueBerry
        {
            get
            {
                if (Fruit == FruitFilling.Blueberry)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Blueberry;
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Cherry
        /// </summary>
        public bool Cherry
        {
            get
            {
                if (Fruit == FruitFilling.Cherry)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Cherry;
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Peach
        /// </summary>
        public bool Peach
        {
            get
            {
                if (Fruit == FruitFilling.Peach)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Peach;
                }
            }
        }

        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withIceCream;
            }
            set
            {
                withIceCream = value;
                NotifyOfPropertyChange("WithIceCream");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        /// <summary>
        /// Notifies when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies order if property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
