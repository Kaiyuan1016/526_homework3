using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed;
    public float upSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal")*forwardSpeed*Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxis("Vertical")*upSpeed*Time.deltaTime);
    }
}
