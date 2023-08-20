using UnityEngine;

public class KapsulHareket : MonoBehaviour
{
    private Transform hedef; 

    public void HedefBelirle(Transform yeniHedef)
    {
        hedef = yeniHedef;
    }

    void Update()
    {
        if (hedef != null)
        {
            
            Vector3 hareketYonu = (hedef.position - transform.position).normalized;
            float hareketHizi = 5.0f;
            transform.Translate(hareketYonu * hareketHizi * Time.deltaTime);
        }
    }
}
