using System.Collections;
using System.Collections.Generic;

public class Background
{
    SKillsENum[] isTrained;

    LanguagesEnum[] languages;

    // equipamento vai entrar aqui

    // proficiencia em ferramentas


}

public class Acolyte : Background
{
    SKillsENum[] isTrained = { SKillsENum.Insight, SKillsENum.Religion };
    LanguagesEnum[] languages = { LanguagesEnum.AtWill, LanguagesEnum.AtWill };
    // equipamento vai entrar aqui
}

public class ClanCrafter : Background
{
    SKillsENum[] isTrained = { SKillsENum.Insight, SKillsENum.Persuasion };
    LanguagesEnum[] languages = { LanguagesEnum.AtWill };
    // equipamento vai entrar aqui
}

public class Artist : Background
{
    SKillsENum[] isTrained = { SKillsENum.Acrobacy, SKillsENum.Perfomance };
    LanguagesEnum[] languages = { };
    // equipamento vai entrar aqui
}

