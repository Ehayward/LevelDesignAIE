using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    public GameObject objectToMove;
    public GameObject particalEffect;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerLift");
            other.transform.SetParent(gameObject.transform);
        }
    }
}
