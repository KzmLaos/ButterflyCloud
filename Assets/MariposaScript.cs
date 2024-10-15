using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MariposaScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool butterflyIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && butterflyIsAlive == true)
        {
        myRigidBody.velocity = Vector2.up * 10;
        }

        if (transform.position.y > 17 || transform);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        butterflyIsAlive = false;
    }
}
