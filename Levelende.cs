using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelende : MonoBehaviour
{ 
    //Das hier ist die genau gleiche Funktion wie beim Neustart-Skript, da es auch um etwas ähnliches geht.
    void OnTriggerEnter(Collider other)
    {
        //Wenn das True ist, kommt eine if-Abfrage. Hier wird gefragt, ob das Objekt mit dem der Box Collider kollidiert ist, den Tag 'Player' hat.
        if(other.tag == "Player") {
            //Wenn auch das True ist, wird in der Konsole "Du hast das Game geschafft!!!" ausgegeben.
            Debug.Log("Du hast das Game geschafft!!!");
        }
    }
}
