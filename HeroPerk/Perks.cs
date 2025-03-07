using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        None = 0,
        WarpShift = 1,  
        Stealth = 2,    
        AutoHeal = 4,  
        DoubleJump = 8  
    }
}
