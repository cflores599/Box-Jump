using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public float lifetime;

    private void Start()
    {
   
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("asadasd");
        if (other.tag == "stand")
        {
            Destroy(other);
        }
    }
}
