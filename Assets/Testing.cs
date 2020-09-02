using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    DwarfRace potato;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log()
        potato = new DwarfRace();
        int languagesIndex = 0;
        foreach (BaseLanguages languages in potato.classLanguages)
        {
            Debug.Log(potato.classLanguages[languagesIndex]);
            languagesIndex++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
