using System;
using System.Collections.Generic;
using System.Text;

namespace L6__EX_Device_Managment
{
    public class Laptop : Device
    {
        public Laptop(string brand, decimal price , string ramSize, string storageSize):base(brand, price)
        {
            RamSize = ramSize;
            StorageSize = storageSize;
        }
        public string RamSize { get; set; }
        public string StorageSize { get; set; }

        public string DisplayLaptopInfo()
        {
            string res = $"Laptop Details: {base.DisplayDeviceInfo()}, Ram Size: {RamSize}, Storage Size: {StorageSize}";
            return res;
        }
    }
}
