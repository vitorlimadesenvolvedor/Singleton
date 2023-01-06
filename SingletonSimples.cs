using System;

namespace Singleton
{
    public sealed class SingletonSimples
    {
        private SingletonSimples()
        {
        }

        public string Name { get; set; }
        private static SingletonSimples _instance;

        public static SingletonSimples GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new SingletonSimples();
                _instance.Name = name;
            }

            return _instance;
        }
    }
}