using UnityEngine;

public class MermiKontrol : MonoBehaviour
{
    // �arp��ma alg�land���nda yap�lacak i�lemler
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dusman")) // Kaps�l prefab�n�n etiketi "Dusman" ise
        {
            // Kaps�l� yok et veya ba�ka bir �l�m i�lemi yapabilirsiniz
            Destroy(other.gameObject);
        }
    }
}
