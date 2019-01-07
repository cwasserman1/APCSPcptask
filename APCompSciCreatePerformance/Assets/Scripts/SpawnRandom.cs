using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject lightMed,heavyMed;
    public float delay ;
    private float instatiateMed;
    public int typeofMed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time>instatiateMed)
        {
            typeofMed = Random.Range(1, 3);
            Debug.Log(typeofMed);
            switch (typeofMed) {
                case 1:
                    Instantiate(lightMed, new Vector3(Random.Range(-7.75f, 7.75f), Random.Range(-3.75f, 3.75f), 0), transform.rotation);
                    break;
                case 2:
                    Instantiate(heavyMed, new Vector3(Random.Range(-7.75f, 7.75f), Random.Range(-3.75f, 3.75f), 0), transform.rotation);
                    break;

            }
            instatiateMed=Time.time+delay;
            
        }
        
    }
    
}
