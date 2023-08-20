using UnityEngine;

public class YokEtme : MonoBehaviour
{
    private bool ucebilir = true;
    public float ziplamaKuvveti = 100.0f;
    public float yokOlmaSuresi = 5.0f;

    void OnCollisionEnter(Collision collision)
    {
        if (ucebilir && collision.gameObject.CompareTag("Cube2"))
        {
            ucebilir = false;

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * ziplamaKuvveti);

            Destroy(gameObject, yokOlmaSuresi);
        }
    }
}
