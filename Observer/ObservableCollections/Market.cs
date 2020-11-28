using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Observer.ObservableCollections
{
    public class Market // observable
    {
        public BindingList<float> Prices = new BindingList<float>();

        public void AddPrice(float price)
        {
            Prices.Add(price);
        }
    }
}