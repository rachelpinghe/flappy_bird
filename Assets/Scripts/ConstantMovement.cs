using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float xSpeed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdControl.bird_alive)
        {
            transform.position += new Vector3(xSpeed, 0, 0) * Time.deltaTime; // Move the object to the right
        } // If the bird is not alive, do not move
    }
}
