using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform ninja;
    void Start()
    {
        
    }
    void Update()
    {
        var x = ninja.position.x + 4f;
        var y = ninja.position.y + 2f;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
