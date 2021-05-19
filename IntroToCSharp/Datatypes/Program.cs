using System;

namespace Datatypes
{
    struct Address
    {
        public string street;
        public string apt;
        public int zipCode;
        public string city;
        public string state;

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double height;
            bool single;
            char sex;
            const string country = "U.S"; // Constant value
            
            id = 1;
            
            // Pointer Referencing and Dereferencing
            unsafe
            {
                int* idPointer = &id; 
                Console.WriteLine(*idPointer);
            }


            name = "John Doe";
            height = 5.9;
            single = true;
            sex = 'M';
            
            Console.WriteLine("ID: " + id + "\nName: " + name + "\nHeight: " + height +
                              "\nSingle: " + single + "\nSex: " + sex);
            
            // Initializing struct
            Address address;
            address.street = " 123th street";
            address.apt = "2A";
            address.city = "Panama";
            address.state = "Ohio";
            address.zipCode = 12345;
            
            Console.WriteLine("Address: " + address.street + " apt " + address.apt + " " +
                              address.city + ", " + address.state + " " + address.zipCode + " " + country );
        }
    }
}