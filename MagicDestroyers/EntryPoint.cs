using System;
using MagicDestroyers.Characters.Melee;

// this is not working 

namespace MagicDestroyers
{
    static class EntryPoint
    {
        static void Main(string[] args)
        {
            Worrior name = new Worrior();

            Console.WriteLine(name.AbilityPoint);
        }
    }
}
