using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;

    public Text txtScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("TxtScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish") {
            Destroy(gameObject);

            int score = int.Parse(txtScore.text);
            score++;
            txtScore.text = score.ToString();
        }
            
    }
}
