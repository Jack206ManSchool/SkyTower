using UnityEngine;

public class CloudAnimationStartPoint : MonoBehaviour
{

    public float startFrame;
    Animator cloudAnimator;

    // Use this for initialization
    void Start()
    {
        cloudAnimator = GetComponent<Animator>();
        cloudAnimator.Play("CloudsLayerAnimation", 0, (startFrame/180));
    }

}