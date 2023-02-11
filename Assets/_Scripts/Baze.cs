using UnityEngine;

public class Baze : MonoBehaviour
{
    [SerializeField] private TrailRenderer _trail;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMovement player))
        {
            _trail.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMovement player))
        {
            _trail.gameObject.SetActive(false);
            FillSelectedZone();
            _trail.Clear();
        }
    }

    private void FillSelectedZone()
    {
        Debug.Log("заполнение");
    }
}
