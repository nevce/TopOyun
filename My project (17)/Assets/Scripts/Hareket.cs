using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float hareketHizi = 2.0f;
    public float ziplamaKuvveti = 50.0f;
    private bool ziplamaIzinli = true;


    void Update()
    {
        float dikeyHareket = Input.GetAxis("Vertical"); 
        float yatayHareket = Input.GetAxis("Horizontal");
        

        
        Vector3 hareket = new Vector3(dikeyHareket, 0.0f,yatayHareket);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(hareket * hareketHizi);

        if (Input.GetKeyDown(KeyCode.Space) && ziplamaIzinli)
        {
            rb.AddForce(Vector3.up * ziplamaKuvveti);
            ziplamaIzinli = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            ziplamaIzinli = true;
        }
    }
}
