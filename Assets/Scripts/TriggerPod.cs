using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPod : MonoBehaviour
{
    public GameObject objectToMove;
    public GameObject particalEffect;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerPod");
            particalEffect.SetActive(true);
        }
    }
}
