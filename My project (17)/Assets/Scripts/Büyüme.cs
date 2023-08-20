using UnityEngine;

public class Büyüme : MonoBehaviour
{
    private bool buyuyebilir = true;
    public float buyumeMiktari = 1.5f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (buyuyebilir && collision.gameObject.CompareTag("Cube"))
        {
            buyuyebilir = false; 
            transform.localScale *= buyumeMiktari;
        }
    }
}
