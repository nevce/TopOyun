using UnityEngine;

public class MermiKontrol : MonoBehaviour
{
    // Çarpýþma algýlandýðýnda yapýlacak iþlemler
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dusman")) // Kapsül prefabýnýn etiketi "Dusman" ise
        {
            // Kapsülü yok et veya baþka bir ölüm iþlemi yapabilirsiniz
            Destroy(other.gameObject);
        }
    }
}
