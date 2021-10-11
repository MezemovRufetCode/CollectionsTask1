using System;

namespace HomeWork
{
    class Lemon
    {
        private string[] arr;
        public string Name;
        public Lemon(string name)
        {
            Name = name;
        }
        public Lemon()
        {
            arr = new string[0];
        }

        public void Add(string num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        public string[] GetArray()
        {
            return arr;
        }
    }
}

