using UnityEngine;

public class KupDondur : MonoBehaviour
{
    public float donmeHizi = 100.0f;

    void Update()
    {
        float fareX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * donmeHizi * Time.deltaTime * fareX);
    }
}
