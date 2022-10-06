using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {


    private void Start()
    {
   
    }

    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "stand")
        {
            Destroy(col);
        }
    }
}
