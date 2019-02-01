using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giraloro : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up);
    }
}
