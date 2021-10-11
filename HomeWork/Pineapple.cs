using System;

namespace HomeWork
{
    class Pineapple
    {
        private string[] arr;
        public string Name;
        public Pineapple(string name)
        {
            Name = name;
        }
        public Pineapple()
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
