using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;


public class CollisionManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text collisionText;
    public int counter = 0;
    public UnityEvent inEventCollision;

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision script : " + other.gameObject.name);
        counter++;
        // collisionText.text = "Collision " + counter;
        inEventCollision.Invoke();
    }
}
