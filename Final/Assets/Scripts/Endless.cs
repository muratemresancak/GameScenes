using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
    public GameObject way1, way2;
    int z1, z2;
    void Start()
    {
        z1 = 0;
        z2 = 40;
    }

    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "w1" && z2 < z1)
        {
            z2 += 80;
            way2.transform.position = new Vector3(0, 0, z2);
            Debug.Log("temas");
        }
        if (other.gameObject.tag == "w2" && z1 < z2) 
        {
            z1 += 80;
            way1.transform.position= new Vector3(0, 0,z1);
            Debug.Log("temas");
        }
    }
}
