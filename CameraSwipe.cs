using UnityEngine;
using System.Collections;

public class CameraSwipe : MonoBehaviour {

    private Touch initTouch = new Touch();
    public Camera cam;

    //for the touches
    private float roty = 0f; //for X make rotx = 0f;
    private Vector3 originalRotation;

    public float rotationSpeed = 0.5f;
    public float direction = -1; //this can be only either +1 or -1.

    

	// Use this for initialization
	void Start () {
        originalRotation = cam.transform.eulerAngles;//eulerAngles used in 3D
        //rotx = originalRotation.x;
        roty = originalRotation.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	foreach(Touch touch in Input.touches) //Checking the state of the touch
        {
            if(touch.phase == TouchPhase.Began)
            {
                initTouch = touch; //this is the current touch
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                //swiping based on the Delta position
                //float deltax = initTouch.position.x - touch.position.x;
                float deltay = initTouch.position.y - touch.position.x;
                //decreasing the eulerAngle
                //rotx -= deltax * Time.deltaTime * rotationSpeed * direction;
                roty -= deltay * Time.deltaTime * rotationSpeed * direction;
                roty += deltay * Time.deltaTime * rotationSpeed * direction;
                cam.transform.eulerAngles = new Vector3(0, roty, 0); //if using rotx, put rotx to the x-axis
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch(); //if the Touch ended
            }
        }
	}
}
