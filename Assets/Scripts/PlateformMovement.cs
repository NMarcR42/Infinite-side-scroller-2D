using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMovement : MonoBehaviour
{
    public float speed = 0;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
