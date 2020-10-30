using System;

namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineStore onlineStore = new OnlineStore();

            onlineStore.ShowStore();
        }
    }
}