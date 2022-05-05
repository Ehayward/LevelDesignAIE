using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antidote : MonoBehaviour
{
    public GameObject ButtonToEnable;
    public bool gotAntidote = false;
    public int speed;
    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(0, speed, 0);
    }
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gotAntidote = true;
            ButtonToEnable.GetComponent<BoxCollider>().enabled = true;
            //Lockcheck takes place at button.

            Destroy(gameObject);
        }
    }
}
