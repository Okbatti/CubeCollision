using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody rb;
     public float forwardForce = 1100f;
    //public float val = SensitivitySlider.slider.value;
     public static float sideWaysForce = 11f;

    // Update is called once per frame

    void FixedUpdate()
       {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.acceleration.x > 0.1 || Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.acceleration.x < -0.1 || Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().tag == "GameColliderStopYaxis")
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
        if (collision.GetComponent<Collider>().tag == "StopPlayer")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (collision.GetComponent<Collider>().tag == "CoinScore")
        {
            Score.score += 10;
            Destroy(collision.gameObject);
        }
    }
}
