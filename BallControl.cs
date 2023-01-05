using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(Vector2.right * 200 * Time.deltaTime, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(Vector2.left * 200 * Time.deltaTime, ForceMode2D.Force);
        }
        
        //if(this.transform.position == )
        //{

        //}
    }

    //void FixedUpdate()
    //{
    //    Debug.DrawRay(this.transform.position, Vector3.down, new Color(0, 1, 0));

    //    RaycastHit2D rayHit = Physics2D.Raycast(this.transform.position, Vector3.down, 1, LayerMask.GetMask("Platform", "Out"));

    //    if (rayHit.collider != null)
    //    {
    //        if (rayHit.distance < 0.2f)
    //        {
    //            if(rayHit.collider.name == "Tilemap")
    //            {
    //                    Debug.Log("¹Ù´Ú¿¡ µµ´ÞÇÏ¿´À½.");
    //                    rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    //            }
    //            if (rayHit.collider.name == "Out")
    //            {
    //                Debug.Log("¾Æ¿ôµÊ");
    //                this.transform.position = new Vector2(-5, -1);
    //            }
    //        }
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Platform")
        {
            Debug.Log("¹Ù´Ú¿¡ µµ´ÞÇÏ¿´À½.");
            rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

        if(collision.collider.tag == "Out")
        {
            Debug.Log("¾Æ¿ôµÊ");
            this.transform.position = new Vector2(-5, -1);
        }
    }
}
