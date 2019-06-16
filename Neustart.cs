using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Hier wurde ein neues Tool eingefügt, da man dies braucht um die Szene neu zu laden.

public class Neustart : MonoBehaviour
{
    //Hier ist eine andere Funktion im Spiel. Das hier schaut ob ein Collider eines Objekts den Collider dieses Objekts berührt. 
    void OnTriggerEnter(Collider other)
    {
        //Wenn das True ist, wird in der Konsole "Spieler tot" ausgegeben. 
        Debug.Log("Spieler tot");
        //wenn der Spieler tot ist kann man nicht weiterspielen, somit wird das Spiel neu geladen. Man hat unendlich weitere Versuche.
        SceneManager.LoadScene("Informatikprojekt, Sandro und Kevin");
    }
}
