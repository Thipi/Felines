using UnityEngine;
using System.Collections;

public class inTheAir : MonoBehaviour {

    Animator Air;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void  FixedUpdate () {

       

        Air = GetComponentInParent<Animator>();
        if(!Physics2D.Raycast(transform.position,Vector2.down, 0.8f))
        {
            Air.SetBool("inAir", true);
        }
	}
}
