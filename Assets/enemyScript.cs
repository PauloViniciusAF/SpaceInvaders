using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.2f;
    private float waitTime = 1.0f;
    private float x;
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
        x = transform.position.x;

        var vel = rb2d.linearVelocity;
        vel.x = speed;
        rb2d.linearVelocity = vel;

    }

    // Update is called once per frame
    void Update()
    {        
        timer += Time.deltaTime;
        if (timer >= waitTime){
            ChangeState();
            timer = 0.0f;
        }
    }
    void ChangeState(){
        var vel = rb2d.linearVelocity;
        vel.x *= -1f;
        rb2d.linearVelocity = vel;
    }

    private void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "Bullet")
            {
                Destroy(gameObject);
            }
    }
}
