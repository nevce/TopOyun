using UnityEngine;

public class Ates : MonoBehaviour
{
    public GameObject mermiPrefab; 
    public Transform atesNoktasi; 
    public float atesHizi = 10.0f; 

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            AtesEt();
        }
    }

    void AtesEt()
    {
        GameObject yeniMermi = Instantiate(mermiPrefab, atesNoktasi.position, atesNoktasi.rotation);
        Rigidbody rb = yeniMermi.GetComponent<Rigidbody>();
        rb.velocity = atesNoktasi.forward * atesHizi;

        float mermiOmru = 2.0f; 
        Destroy(yeniMermi, mermiOmru);
    }
}
