using UnityEngine;
using UnityEngine.UIElements;

public class Movimentacao_Player : MonoBehaviour
{
    public Rigidbody rb;
    public float Veloc = 2.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

       Vector2 movimentação = new Vector2 (x, y).normalized;

        transform.Translate(movimentação * Veloc * Time.deltaTime);
    }

    
}
