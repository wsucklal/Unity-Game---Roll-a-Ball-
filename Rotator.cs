using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        //Rotates the objects around the Y axis
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
