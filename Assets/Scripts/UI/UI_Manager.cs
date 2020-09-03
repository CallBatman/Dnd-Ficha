using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    private CurrentCharacter currentCharacter;

    void Start()
    {
        currentCharacter = GameObject.FindGameObjectWithTag("CurrentCharacter").GetComponent<CurrentCharacter>();
    }

    private void Update()
    {

    }

    public void OnDropDownRaceUpdate(int value)
    {
        switch (value)
        {
            case 0:
                break;
            case 1:
                currentCharacter.currentSheet.characterRace = Races.Human;
                break;
            case 2:
                currentCharacter.currentSheet.characterRace = Races.Dragonborn;
                break;
            case 3:
                currentCharacter.currentSheet.characterRace = Races.Elf;
                break;
            case 4:
                currentCharacter.currentSheet.characterRace = Races.HalfElf;
                break;
            case 5:
                currentCharacter.currentSheet.characterRace = Races.Orc;
                break;
            case 6:
                currentCharacter.currentSheet.characterRace = Races.HalfOrc;
                break;
            case 7:
                currentCharacter.currentSheet.characterRace = Races.Tiefling;
                break;
            case 8:
                currentCharacter.currentSheet.characterRace = Races.Halfling;
                break;
            case 9:
                currentCharacter.currentSheet.characterRace = Races.Goliath;
                break;
            case 10:
                currentCharacter.currentSheet.characterRace = Races.Dwarf;
                break;
        }
    }
}