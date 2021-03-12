using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private int count;
    public Text countText;
    public Text winText;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = count - count;

        SetCountText();

        winText.text = "";

    }

    void Update()
    {
        if (count >= 15 )
        {
            Invoke("ResetGame", 3);

        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement* speed );
    }

    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("Coin"))
        {
            
          
                Destroy(other.gameObject);
            
                count = count + 1;
                
                SetCountText();
            
            
        }

        else if (other.gameObject.CompareTag("SingleBrick"))
        {
            
                Destroy(other.gameObject);
            
                 count = count + 2;

                SetCountText();
            
        }

        else if (other.gameObject.CompareTag("LegoBrick"))
        {
            
                Destroy(other.gameObject);
          
                count = count + 3;
                
                SetCountText();
            
        }
    }


   
    void SetCountText()
    {
        countText.text = "Score: " + (count).ToString();
        
        if (count >= 15)
        {
            winText.text = "Winner!";
        }
    }

    void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

