using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Für den Timer brauchte es 2 neue Tools. Das eine ist für das Mangement der Szenen und das andere für den Text verantwortlich. 
//Mit denen hat man mehr Möglichkeiten um das zu machen, was man braucht.

public class TimerText : MonoBehaviour
{
    //Hier wird definiert dass diese beiden Sachen 'In Game' verfügbar sind. Dies weil sie auf private sind. Somit kann man auch während des Spiels den Timer verstellen.
    public Text timerText;
    public float roundTimer;

    void Update() //Update Funktion wird jeden Frame ausgeführt
    {

        roundTimer = roundTimer - Time.deltaTime;
        //Hier wird der Timer gesteuert. Der Anfangstimerwert - die Zeit die vergangen ist, ergibt den neuen Timerwert. Von diesem wird dann wieder die Zeit die vergangen ist
        // abgezogen und wieder auf 'roundTimer' abgespeichert.
        int roundTimerInt = (int)roundTimer;
        //Hier wird der Timer auf ganze Zahlen gerundet, da sonst 6 Nachkommastellen angezeigt werden.
        timerText.text = roundTimerInt.ToString();
        //Hier wird der Wert(die Zeit), in einem String, an den timerText weitergeleitet und dann sieht man es während des Spieles.

        if (roundTimer <= 0f)
        {   //Hier wird gefragt ob der Timer auf 0 oder kleiner ist

            //Wenn diese if-Abfrage auf True ist ist die Zeit abgelaufen und dies wird auch so in der Konsole ausgegeben. 
            Debug.Log("Zeit ist abgelaufen.");
            //Wenn die if-Abfrage True ist wird das hier ausgeführt, der Timer wird auf 0 gesetzt, damit er nicht unter 0 gehen kann.
            roundTimer = 0;
            SceneManager.LoadScene("Informatikprojekt, Sandro und Kevin");
            //Im untersten Teil wird wie schon im Neustart-Skript das Spiel neugestartet. Da der Timer abgelaufen ist und der Spieler noch nicht im Ziel war. 
            //Man hat unendlich Versuche.

        }
   
    }
}
