using System;

namespace HomeWork
{
    class Apple
    {
        private string[] arr;
        public string Name;
        public Apple(string name)
        {
            Name = name;
        }
        public Apple()
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
