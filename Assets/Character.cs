using System.Collections;
using System.Collections.Generic;

public class Character
{
    string playerName;

    string name;

    RaceClass characterRaces;

    // aqui vão entrar as classes

    int level;

    int exp;

    AlignmentEnum alignment;

    // aqui vai o background

    int inspiration;
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
    public class Acrobacy
    {
        int acrobacy;
        bool isTrained;
        public SkillModifier acrobacyModifier
        {
            get { return acrobacyModifier; }
            private set { acrobacyModifier = SkillModifier.dexterity; }

        }
    }
    public class Arcanism
    {
        int arcanism;
        bool isTrained;
        public SkillModifier arcanismModifier
        {
            get { return arcanismModifier; }
            private set { arcanismModifier = SkillModifier.inteligence; }
        }
    }
    public class Atletism
    {
        int atletism;
        bool isTrained;
        public SkillModifier atletismModifier
        {
            get { return atletismModifier; }
            private set { atletismModifier = SkillModifier.strenght; }
        }
    }
    public class Perfomance
    {
        int perfomance;
        bool isTrained;
        public SkillModifier perfomanceModifier
        {
            get { return perfomanceModifier; }
            private set { perfomanceModifier = SkillModifier.charisma; }
        }
    }
    public class Deception
    {
        int deception;
        bool isTrained;
        public SkillModifier deceptionModifier
        {
            get { return deceptionModifier; }
            private set { deceptionModifier = SkillModifier.charisma; }
        }
    }
    public class Stealth
    {
        int stealth;
        bool isTrained;
        public SkillModifier stealthModifier
        {
            get { return stealthModifier; }
            private set { stealthModifier = SkillModifier.dexterity; }
        }
    }
    public class History
    {
        int history;
        bool isTrained;
        public SkillModifier historyModifier
        {
            get { return historyModifier; }
            private set { historyModifier = SkillModifier.inteligence; }
        }
    }
    public class Intimidation
    {
        int intimidation;
        bool isTrained;
        public SkillModifier intimidationModifier
        {
            get { return intimidationModifier; }
            private set { intimidationModifier = SkillModifier.charisma; }
        }
    }
    public class Insight
    {
        int insight;
        bool isTrained;
        public SkillModifier insightModifier
        {
            get { return insightModifier; }
            private set { insightModifier = SkillModifier.wisdom; }
        }

    }
    public class Investigation
    {
        int investigation;
        bool isTrained;
        public SkillModifier investigationModifier
        {
            get { return investigationModifier; }
            private set { investigationModifier = SkillModifier.inteligence; }
        }
    }
    public class AnimalHandling
    {
        int animalHandling;
        bool isTrained;
        public SkillModifier animalHandlingModifier
        {
            get { return animalHandlingModifier; }
            private set { animalHandlingModifier = SkillModifier.wisdom; }
        }
    }
    public class Medicine
    {
        int medicine;
        bool isTrained;
        public SkillModifier medicineModifier
        {
            get { return medicineModifier; }
            private set { medicineModifier = SkillModifier.wisdom; }
        }
    }
    public class Nature
    {
        int nature;
        bool isTrained;
        public SkillModifier natureModifier
        {
            get { return natureModifier; }
            private set { natureModifier = SkillModifier.inteligence; }
        }
    }
    public class Perception
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
}
