using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combi : MonoBehaviour
{

    private bool canJump = true;
    private int currentPosition = 1;

    public int[] xPosition;

    public Rigidbody rb;
    public float jumpForce = 1f;

    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(0, 1, -20);
        pos.x = xPosition[currentPosition];
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentPosition--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentPosition++;
        }

        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }



        if (currentPosition < 0)
            currentPosition = 0;

        //if (currentPosition > 2)
        //    currentPosition = 2;
        if (currentPosition >= xPosition.Length)
            currentPosition = xPosition.Length-1;
        

        Vector3 pos = transform.position;
        pos.x = xPosition[currentPosition];
        transform.position = pos;
    }

    void FixedUpdate() {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground")
            canJump = true;

        if (collision.gameObject.tag == "Enemy")
        {
            text.text = "Dead";
        }
    }


}
