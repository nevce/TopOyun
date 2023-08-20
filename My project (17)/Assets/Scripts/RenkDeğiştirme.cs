using UnityEngine;

public class RenkDeğiştirme : MonoBehaviour
{
    private bool renkDegisebilir = true;
    public Color yeniRenk;

    private void OnCollisionEnter(Collision collision)
    {
        if (renkDegisebilir && collision.gameObject.CompareTag("Cube1"))
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = yeniRenk;
        }
    }
}
