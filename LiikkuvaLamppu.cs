using UnityEngine;
using System.Collections;

public class LiikkuvaLamppu : MonoBehaviour {

    private Vector3 startPoint;
    private Vector3 destination;
    private Vector3 nextPosition;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform childTransform;
    [SerializeField]
    private Transform transformB;

	// Use this for initialization
	void Start () {
        startPoint = childTransform.localPosition;
        destination = transformB.localPosition;
        nextPosition = destination;
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    private void Movement()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPosition, speed * Time.deltaTime);
        if(Vector3.Distance(childTransform.localPosition, nextPosition) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        nextPosition = nextPosition != startPoint ? startPoint : nextPosition; //takes the next position and changes it. If it isn't start --> it will change
        
    }

}
