using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TriggerManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text triggerText;
    public int counter = 0;
    public UnityEvent eventTrigger;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        eventTrigger.AddListener(gameManager.DisplayCanvas);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger script : " + other.name);
        counter++;
        // triggerText.text = "Trigger " + counter;
        eventTrigger.Invoke();
    }
}
