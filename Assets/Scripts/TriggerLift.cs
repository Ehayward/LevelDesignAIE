using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    public GameObject objectToMove;
    public Transform lift;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerLift");
        
        }
    }
}
