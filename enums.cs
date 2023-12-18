using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    enum AttackType
    {
        Physical = 1,
        Magical
    }

    enum Weather
    {
        Sun,    // Base weather
        Rain,   // Increases magic damage
        Wind,   // Reduce archer damage
        Snow    // Reduce physical damage
    }

    enum Location
    {
        Plato,      // Base location, no buffs
        Mountains,  // Reduces wind debuff, and increases snow debuff
        Forest      // + Dodge chance
    }

}
