using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class astronautController : MonoBehaviour{
    public float speed;

    private int count;
    private Rigidbody2D rb2d;

    void Start(){
        rb2d = GetComponent<Rigidbody2D> ();
        count = 0;
    }

    void FixedUpdate(){
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);*/

        Vector3 pos = transform.position;

        if (Input.GetKey ("w")) {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey ("s")) {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey ("d")) {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey ("a")) {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
        //rb2d.AddForce(movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other){
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp")){
             other.gameObject.SetActive(false);
              count++;
        }
    }
}
