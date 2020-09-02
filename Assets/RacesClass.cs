using System.Collections;
using System.Collections.Generic;

public class RacesClass
{
    int baseStrBonus;
    int baseDexBonus;
    int baseConBonus;
    int baseIntBonus;
    int baseChaBonus;
    int baseWisBonus;

    int baseSpeed;

    BaseLanguages[] classLanguages;
    }

public class HumanRace : RacesClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 0;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 6;

    public BaseLanguages[] classLanguages = new BaseLanguages[1] { BaseLanguages.Common };

    
   

}
public class ElfRace : RacesClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 2;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 7;

    public BaseLanguages[] classLanguages = new BaseLanguages[2] { BaseLanguages.Common, BaseLanguages.Elven };

}
public class DwarfRace : RacesClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 0;
    public int baseConBonus = 2;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 5;

    public BaseLanguages[] classLanguages = new BaseLanguages[2] { BaseLanguages.Common, BaseLanguages.Dwarfic };
}
