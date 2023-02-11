using UnityEngine;

public class PlayerCollisionTrail : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EdgeCollider2D collider))
        {
            Destroy(gameObject);
        }
    }
}
