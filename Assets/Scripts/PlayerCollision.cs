
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager _manager;
    

    private void OnCollisionEnter (Collision col)
    {
        if (col.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //_manager.EndGame();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
