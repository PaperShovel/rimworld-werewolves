using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Rimworld_Werewolves
{
    [StaticConstructorOnStartup]
    public static class Werewolf
    {
        static Werewolf()
        {
            Log.Message("Hello World!"); //Outputs "Hello World!" to the dev console.
        }
    }
}
