using System.Collections;
using System.Collections.Generic;

public class RaceClass
{
    int baseStrBonus;
    int baseDexBonus;
    int baseConBonus;
    int baseIntBonus;
    int baseChaBonus;
    int baseWisBonus;

    int baseSpeed;

    LanguagesEnum[] classLanguages;
}

public class HumanRace : RaceClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 0;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 6;

    public LanguagesEnum[] classLanguages = new LanguagesEnum[1] { LanguagesEnum.Common };
}
public class ElfRace : RaceClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 2;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 7;

    public LanguagesEnum[] classLanguages = new LanguagesEnum[2] { LanguagesEnum.Common, LanguagesEnum.Elven };
}
public class HalfElf : RaceClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 0;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 6;

    public LanguagesEnum[] classLanguages = new LanguagesEnum[2] { LanguagesEnum.Common, LanguagesEnum.Elven };
}
public class DwarfRace : RaceClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 0;
    public int baseConBonus = 2;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 5;

    public LanguagesEnum[] classLanguages = new LanguagesEnum[2] { LanguagesEnum.Common, LanguagesEnum.Dwarfic };
}

public class HalflingRace : RaceClass
{
    public int baseStrBonus = 0;
    public int baseDexBonus = 2;
    public int baseConBonus = 0;
    public int baseIntBonus = 0;
    public int baseChaBonus = 0;
    public int baseWisBonus = 0;

    public int baseSpeed = 5;

    public LanguagesEnum[] classLanguages = new LanguagesEnum[2] { LanguagesEnum.Common, LanguagesEnum.Halfling };
}
