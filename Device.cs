using System;
using System.Collections.Generic;
using System.Text;

namespace L6__EX_Device_Managment
{
    public class Device
    {
        public Device(string brand, decimal price)
        {
            Brand = brand;
            Price = price;
        }

        public string Brand { get; set; }
        public decimal Price { get; set; }

        public string DisplayDeviceInfo()
        {
            string res = $"Brand: {Brand}, Price: {Price}";
            return res;
        }
    }
}
