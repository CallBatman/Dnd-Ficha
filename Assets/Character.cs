using System.Collections;
using System.Collections.Generic;

public class Character
{
    string playerName;

    string name;

    RacesClass characterRaces;

    // aqui vão entrar as classes

    int level;

    int exp;

    // aqui vai a tendencia

    // aqui vai o background

    int inspiration;
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
        int acrobacyValue;
        bool isTrained;
        public SkillModifier acrobacyModifier
        {
            get { return acrobacyModifier; }
            private set { acrobacyModifier = SkillModifier.dexterity; }

        }
        public class Arcanism
        {
            int arcanism;
            bool isTrained;
            SkillModifier arcanismModifier = SkillModifier.inteligence;
        }
        public class Atletism
        {
            int atletism;
            bool isTrained;
            SkillModifier atletismModifier = SkillModifier.strenght;
        }
        public class Perfomance
        {
            int perfomance;
            bool isTrained;
            SkillModifier perfomanceModifier = SkillModifier.charisma;
        }
        public class Deception
        {
            int deception;
            bool isTrained;
            SkillModifier deceptionModifier = SkillModifier.charisma;
        }
        public class Stealth
        {
            int stealth;
            bool isTrained;
            SkillModifier stealthModifier = SkillModifier.dexterity;
        }
        public class History
        {
            int history;
            bool isTrained;
            SkillModifier historyModifier = SkillModifier.inteligence;
        }
        public class Intimidation
        {
            int intimidation;
            bool isTrained;
            SkillModifier intimidationModifier = SkillModifier.charisma;
        }
        public class Insight
        {
            int insight;
            bool isTrained;
            SkillModifier insightModifier = SkillModifier.wisdom;
        }
        public class Investigation
        {
            int investigation;
            bool isTrained;
            SkillModifier investigationModifier = SkillModifier.inteligence;
        }
        public class AnimalHandling
        {
            int animalHandling;
            bool isTrained;
            SkillModifier animalHandlingModifier = SkillModifier.wisdom;
        }
        public class Medicine
        {
            int medicine;
            bool isTrained;
            SkillModifier medicineModifier = SkillModifier.wisdom;
        }
        public class Nature
        {
            int nature;
            bool isTrained;
            SkillModifier natureModifier = SkillModifier.inteligence;
        }
        public class Perception
        {
            int perception;
            bool isTrained;
            SkillModifier perceptionModifier = SkillModifier.wisdom;
        }
        public class Persuasion
        {
            int persuasion;
            bool isTrained;
            SkillModifier persuasionModifier = SkillModifier.charisma;
        }
        public class Prestidigitation
        {
            int prestidigitation;
            bool isTrained;
            SkillModifier prestidigitationModifier = SkillModifier.dexterity;
        }
        public class Religion
        {
            int religion;
            bool isTrained;
            SkillModifier religionModifier = SkillModifier.inteligence;
        }
        public class Survival
        {
            int survival;
            bool isTrained;
            SkillModifier survivalModifier = SkillModifier.wisdom;
        }
    }
}