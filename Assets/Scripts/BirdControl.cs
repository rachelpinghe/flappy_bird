using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add this at the top

public class BirdControl : MonoBehaviour
{
    public float jumpForce = 10f;
    public static bool bird_alive = true;
    public GameObject failText;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bird_alive)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            // Make the bird jump
            rb.velocity = new Vector3(0, jumpForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        bird_alive = false; // Set bird_alive to false when a collision occurs
        failText.SetActive(true); // Show the fail text
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
