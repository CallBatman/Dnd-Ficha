using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCharacter : MonoBehaviour
{
    public Character currentSheet;

    public RaceClass characterRace;

    void Start()
    {
        currentSheet = new Character();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log(currentSheet.characterRace);
        }
    }
}
