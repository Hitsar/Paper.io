using UnityEngine;

public class Baze : MonoBehaviour
{
    [SerializeField] private TrailRenderer _trail;
    [SerializeField] private MeshRenderer _renderer;

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
        _renderer.probeAnchor = _trail.probeAnchor;
        Debug.Log("заполнение");
    }
}
