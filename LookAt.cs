using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Diese zwei Zeilen, machen dass die Kamera immer auf das Objekt schaut.
    //Dies ist sehr wichtig da sonst der Spieler den Spielball aus den Augen verliert.
    public Transform target;

    //void Update() wird jeden Frame ausgeführt.
    void Update()
    {
        transform.LookAt(target);

    }
}