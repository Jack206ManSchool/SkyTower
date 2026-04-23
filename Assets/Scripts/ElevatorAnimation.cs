using UnityEngine;

public class ElevatorAnimation : MonoBehaviour
{

    Animator elevatorAnimator;

    // Use this for initialization
    void Start()
    {
        elevatorAnimator = GetComponent<Animator>();
        
    }

    public void Update()
    {
        //print(Event.current);
        if (Event.current != null)
        {
            Event inputEvent = Event.current;
            if (inputEvent.keyCode == KeyCode.Alpha1)
            {
                elevatorAnimator.SetInteger("Position", 1);
            }
            else if (inputEvent.keyCode == KeyCode.Alpha2)
            {
                elevatorAnimator.SetInteger("Position", 2);
            }
        }
    }

}