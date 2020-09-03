using System.Collections;
using System.Collections.Generic;

public class Character
{
    public string playerName;

    public string name;

    public Races characterRace;

    public RaceClass characterRaceBonus;

    // aqui vão entrar as classes

    public int level;

    public int exp;

    public AlignmentEnum alignment;

    public CharacterInfo characeterInfo;

    public Background characterBackground;

    public int inspiration;

    public CharacterAtributes characterAtributes;

    public CharacterSkills CharacterSkills;
}

public class CharacterInfo : Character
{
    string personalityTraits;

    string ideals;

    string bonds;

    string flaws;
}

public class CharacterAtributes : Character
{
    int strenght;
    int strenghtBonus;

    int dexterity;
    int dexterityBonus;

    int constitution;
    int constitutionBonus;

    int inteligence;
    int inteligenceBonus;

    int wisdom;
    int wisdomBonus;

    int charisma;
    int charismaBonus;

    int proficiencyBonus;
}

public class CharacterSkills : Character
{

    Acrobacy acrobacy;
    Arcanism arcanism;
    Atletism atletism;
    Perfomance perfomance;
    Deception deception;
    Stealth stealth;
    History history;
    Intimidation intimidation;
    Insight insight;
    Investigation investigation;
    AnimalHandling animalHandling;
    Medicine medicine;
    Nature nature;
    Perception perception;
    Persuasion persuasion;
    Prestidigitation prestidigitation;
    Religion religion;
    Survival survival;

    #region SkillClasses

    public class Acrobacy : CharacterSkills
    {
        int acrobacy;
        bool isTrained;
        public SkillModifier acrobacyModifier
        {
            get { return acrobacyModifier; }
            private set { acrobacyModifier = SkillModifier.dexterity; }

        }
    }
    public class Arcanism : CharacterSkills
    {
        int arcanism;
        bool isTrained;
        public SkillModifier arcanismModifier
        {
            get { return arcanismModifier; }
            private set { arcanismModifier = SkillModifier.inteligence; }
        }
    }
    public class Atletism : CharacterSkills
    {
        int atletism;
        bool isTrained;
        public SkillModifier atletismModifier
        {
            get { return atletismModifier; }
            private set { atletismModifier = SkillModifier.strenght; }
        }
    }
    public class Perfomance : CharacterSkills
    {
        int perfomance;
        bool isTrained;
        public SkillModifier perfomanceModifier
        {
            get { return perfomanceModifier; }
            private set { perfomanceModifier = SkillModifier.charisma; }
        }
    }
    public class Deception : CharacterSkills
    {
        int deception;
        bool isTrained;
        public SkillModifier deceptionModifier
        {
            get { return deceptionModifier; }
            private set { deceptionModifier = SkillModifier.charisma; }
        }
    }
    public class Stealth : CharacterSkills
    {
        int stealth;
        bool isTrained;
        public SkillModifier stealthModifier
        {
            get { return stealthModifier; }
            private set { stealthModifier = SkillModifier.dexterity; }
        }
    }
    public class History : CharacterSkills
    {
        int history;
        bool isTrained;
        public SkillModifier historyModifier
        {
            get { return historyModifier; }
            private set { historyModifier = SkillModifier.inteligence; }
        }
    }
    public class Intimidation : CharacterSkills
    {
        int intimidation;
        bool isTrained;
        public SkillModifier intimidationModifier
        {
            get { return intimidationModifier; }
            private set { intimidationModifier = SkillModifier.charisma; }
        }
    }
    public class Insight : CharacterSkills
    {
        int insight;
        bool isTrained;
        public SkillModifier insightModifier
        {
            get { return insightModifier; }
            private set { insightModifier = SkillModifier.wisdom; }
        }

    }
    public class Investigation : CharacterSkills
    {
        int investigation;
        bool isTrained;
        public SkillModifier investigationModifier
        {
            get { return investigationModifier; }
            private set { investigationModifier = SkillModifier.inteligence; }
        }
    }
    public class AnimalHandling : CharacterSkills
    {
        int animalHandling;
        bool isTrained;
        public SkillModifier animalHandlingModifier
        {
            get { return animalHandlingModifier; }
            private set { animalHandlingModifier = SkillModifier.wisdom; }
        }
    }
    public class Medicine : CharacterSkills
    {
        int medicine;
        bool isTrained;
        public SkillModifier medicineModifier
        {
            get { return medicineModifier; }
            private set { medicineModifier = SkillModifier.wisdom; }
        }
    }
    public class Nature : CharacterSkills
    {
        int nature;
        bool isTrained;
        public SkillModifier natureModifier
        {
            get { return natureModifier; }
            private set { natureModifier = SkillModifier.inteligence; }
        }
    }
    public class Perception : CharacterSkills
    {
        int perception;
        bool isTrained;
        public SkillModifier perceptionModifier
        {
            get { return perceptionModifier; }
            private set { perceptionModifier = SkillModifier.wisdom; }
        }
    }
    public class Persuasion
    {
        int persuasion;
        bool isTrained;
        public SkillModifier persuasionModifier
        {
            get { return persuasionModifier; }
            private set { persuasionModifier = SkillModifier.charisma; }
        }
    }
    public class Prestidigitation
    {
        int prestidigitation;
        bool isTrained;
        public SkillModifier prestidigitationModifier
        {
            get { return prestidigitationModifier; }
            private set { prestidigitationModifier = SkillModifier.dexterity; }
        }
    }
    public class Religion
    {
        int religion;
        bool isTrained;
        public SkillModifier religionModifier
        {
            get { return religionModifier; }
            private set { religionModifier = SkillModifier.inteligence; }
        }
    }
    public class Survival
    {
        int survival;
        bool isTrained;
        public SkillModifier survivalModifier
        {
            get { return survivalModifier; }
            private set { survivalModifier = SkillModifier.wisdom; }
        }
    }

    #endregion
}
