using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gerenciador_Cenas : MonoBehaviour
{
    public static bool Esta_Dentro = false; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Esta_Dentro = true && Input.GetKeyDown(KeyCode.E)) 
        {
            SceneManager.LoadScene("Casa_fazenda");
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (CompareTag("Triggers"))
        {
            Esta_Dentro = true;
            Debug.Log("Viro True");
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (CompareTag("Triggers"))
        {
            Esta_Dentro = false;
            Debug.Log("Viro false");
        }
    }
}
