using UnityEngine;

public class CapsuleSpawn : MonoBehaviour
{
    public GameObject kapsulPrefab; 
    public Transform hedef;
    public float spawnHizi = 2.0f;

    void Start()
    {
        InvokeRepeating("KapsulSpawnEt", 0.0f, spawnHizi);
    }

    void KapsulSpawnEt()
    {
        Vector3 spawnKonumu = new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f));
        GameObject yeniKapsul = Instantiate(kapsulPrefab, spawnKonumu, Quaternion.identity);
        yeniKapsul.GetComponent<KapsulHareket>().HedefBelirle(hedef);
    }
}
