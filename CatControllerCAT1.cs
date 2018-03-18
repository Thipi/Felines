using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CatControllerCAT1 : MonoBehaviour
{

    Rigidbody2D CatRB;
    public float maxspeed;

    bool maassa = false;
    float maassaradius = 0.2f; //tiny circle in the characters feet to check if he's grounded. It's radius is atm 0.5.
    public LayerMask groundLayer;
    public float speed;
    public Transform maassako; //position, are we grounded? checking the ground.
    public float JumpHeight;  //force added to jump
    bool jump = false;
    Animator catJumpAnim;

    //public bool dropAllowed = false;




    // Use this for initialization
    void Start()
    {

        CatRB = GetComponent<Rigidbody2D>();
        //dropAllowed = false;
        catJumpAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (maassa && Input.GetAxis("Jump") > 0)
        {
            maassa = false;
            Jump();
        }

        
        }


    void FixedUpdate()
    {
        // Debug.DrawRay(maassako.position, Vector2.down, Color.red);
        maassa = Physics2D.OverlapCircle(maassako.position, maassaradius, groundLayer); //we are grounded if: (grounded? at this position, check the radius, layermask)
        float move = Time.deltaTime + speed;
        CatRB.velocity = new Vector2(move * maxspeed, CatRB.velocity.y);

        catJumpAnim.SetFloat("verticalSpeed", CatRB.velocity.y);

        if (!Physics2D.OverlapCircle(maassako.position, maassaradius, groundLayer))
        {
            catJumpAnim.SetTrigger("onmaassa 0");
        }

    }
       
        //catJumpAnim.SetFloat("verticalSpeed", CatRB.velocity.y);
        //catJumpAnim = GetComponent<Animator>();

      
    

    public void Jump()
    {

    if (maassa)
    {

        maassa = false;
        catJumpAnim.SetTrigger("onmaassa 0");
        CatRB.AddForce(new Vector2(0, JumpHeight)); //adding force
                                                    //catJumpAnim.SetTrigger("onmaassa 0");
        }    
    }

    public void OnTriggerCollision2D(Collider2D other)
    {
        if (other.tag == "vesi")
        {
            CatRB.AddForce(new Vector2(10, 200));

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "kori")
        {
            CatRB.velocity = new Vector2(0, CatRB.velocity.y);
        }
        else if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform; //muuttaa hetkeksi liikkuvan alustan pikkukaverin "vanhemmaksi".
            maassa = true;
        }
        else if(other.transform.tag == "PowerUp")
        {
            maxspeed = maxspeed + 1f;
                
        }
        else if(other.transform.tag == "hidastus")
        {
            maxspeed -= 5f;
        }
        }

    void OnCollisionExit2D(Collision2D other) //kun poistuu liikkuvalta alustalta, MovingPlatform ei ole enää parent.
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }


    }





    //  public void DropButton()
    // {

    //       Paw.SetActive(true);
    //     Debug.Log("ButtonDown!");
    //   dropAllowed = false;

    //}



    //   void TheDropDown()
    // {
    //   if (gameObject.layer == LayerMask.NameToLayer("pisteEsine") && dropAllowed)
    // {
    //  Debug.Log("buttonDown!");
    //ScoreManager.AddPoints(pointsToAdd);
    //dropAllowed = false;
    // }
    //  }


}


    
    

