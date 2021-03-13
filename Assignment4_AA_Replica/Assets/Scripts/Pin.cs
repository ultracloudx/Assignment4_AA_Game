using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D rb;
    

    private bool isPinned = false;

    private void FixedUpdate()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed *= -1;
            Score.PinCount++;
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    
}
