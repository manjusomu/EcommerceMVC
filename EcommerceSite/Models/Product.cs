using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceSite.Models
{
    public class Product
    {
        public Laptop LapDetails(int id)
        {
            Laptop lap = new Laptop();
            switch(id)
            {
                case 1:
                    lap = new Laptop()
                    {
                        ProductId = 101,
                        Brand = "lenovo",
                        Model = "i3",
                        Price = 27000
                    };
                    break;
                case 2:
                    lap = new Laptop()
                    {
                        ProductId = 105,
                        Brand = "samsung",
                        Model = " corei7",
                        Price = 82000
                    };
                    break;
                case 3:
                    lap = new Laptop()
                    {
                        ProductId = 102,
                        Brand = "Hp",
                        Model = "i7",
                        Price = 45000
                    };
                    break;
                case 4:
                    lap = new Laptop()
                    {
                        ProductId = 103,
                        Brand = "Dell",
                        Model = "core i5",
                        Price = 53300
                    };
                    break;
            }
            return lap;
        }
    }
}