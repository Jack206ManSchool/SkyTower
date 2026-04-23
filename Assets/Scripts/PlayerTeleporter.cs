using UnityEngine;

public class PlayerFallTeleport : MonoBehaviour
{

    public GameObject player;
    public GameObject teleportPoint;
    private GameObject playerCapsule;
    private CharacterController controlComponent;

    private void Start()
    {
        playerCapsule = player.transform.Find("PlayerCapsule").gameObject;
        controlComponent = playerCapsule.GetComponent<CharacterController>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(player != null && teleportPoint != null)
            if (collision.gameObject.transform.parent.name == player.name) {
                controlComponent.enabled = false;
                player.transform.Find("PlayerCapsule").transform.position = teleportPoint.transform.position;
                controlComponent.enabled = true;
            }
    }

}
