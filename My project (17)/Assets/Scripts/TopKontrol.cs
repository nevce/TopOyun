using UnityEngine;
using UnityEngine.SceneManagement; 
public class TopKontrol : MonoBehaviour
{
    public string Level2; 
    public float beklemeSuresi = 10f; 

    void Start()
    {
        Invoke("SahneDegistir", beklemeSuresi);
    }

    void SahneDegistir()
    {
        SceneManager.LoadScene(Level2);
    }
}
