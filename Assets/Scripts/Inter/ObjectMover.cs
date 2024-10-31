using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed = 10f;
    public bool smoothDamp;

    //Private Variables

    bool isNewPositionActive = false;
    Vector3 oldPosition;

    Vector3 targetPosition;

    Vector3 currentSpeed;
        //for SmoothDamp


    void Start()
    {

        oldPosition = transform.position;
        targetPosition = oldPosition;
    }

    
    void Update()
    {
        Vector3 currentPosition = transform.position;
        if (smoothDamp)
            transform.position = Vector3.SmoothDamp(currentPosition, targetPosition, ref currentSpeed, 2f / speed);
        else
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);
    }

    public void MoveObject()
    {
        if (isNewPositionActive)
            targetPosition = newPosition;
        else
            targetPosition = oldPosition;
    }
}
