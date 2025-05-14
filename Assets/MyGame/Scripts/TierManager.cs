using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TierManger : Tier
{
    // Start is called before the first frame update
    void Start()
    {
        Hund hund = new Hund();

        Debug.Log("Der Hund hat ein Gewicht von" + gewicht + "kg");
        hund.Geraeusch();
    }


}