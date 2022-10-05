using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject standPrefab;
    private float lastRandX=0;
    
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instantiate()
    {
        float randX = Random.Range(0, 1);
    
        float randScalex = Random.Range(1.6f, 2.1f);
        float randScaley = Random.Range(1.5f, 4.5f);
      
        GameObject stand= Instantiate(standPrefab, new Vector3(transform.position.x + randX,transform.position.y,transform.position.z), Quaternion.identity);
        stand.transform.localScale = new Vector3(randScalex, randScaley, 1);
       
    }
}
