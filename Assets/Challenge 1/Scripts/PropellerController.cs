using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Time.deltaTime, 0, 10);
        ;

    }
}
