using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public AudioSource Pickup;
    public Text countText;
    public AudioClip dead;


    private Rigidbody2D rb2d;
    private int count;
   


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Pickup = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D> ();
        SetcountText();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);

     }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Pickup.Play();
            other.gameObject.SetActive(false);

            count = count + 1;

            SetcountText();

        }

    }

    void SetcountText()
    {
        countText.text = "count: " + count.ToString();

    } 
}
