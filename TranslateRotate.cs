using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateRotate : MonoBehaviour
{
    //Hier ist die Geschwindigkeit der verschiedenen Bewegungen abgespeichert, da sie jedoch auf public sind können sie im Game verändert werden.
    public float moveSpeed = 5f;
    public float rotSpeed = 5f;
    public float jumpSpeed = 20f;

    //Hier ist die Steuerung mit W, A, S, D und Leertaste zum Springen.
    //Es wird jeweils der Vector3 geänder und mit dem oben definierten Speed mulitipliziert. Ebenfalls wird das noch mit Time.deltaTime multipliziert, dies ist dafür, dass 
    //jeder Spieler gleiche Chancen hat. Auch wenn der Ping sich ändert. Diese Funktion wurde von allen Youtubern erklärt. Das heisst sie ist sehr populär. 
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
        }
    }
}
