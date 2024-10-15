using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadZone = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed);
        if(transform.position.x < deadZone)
        {
            Debug.Log("Nube Deleted");
            Destroy(gameObject);
        }
        Debug.Log(moveSpeed);
    }
}
