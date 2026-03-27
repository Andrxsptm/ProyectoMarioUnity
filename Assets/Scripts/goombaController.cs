using UnityEngine;

public class goombaController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            if (other.CompareTag("Mario"))
            {
                GameEngine.Instance.QuitarVidas();
                Debug.Log("Quito una vida");
            }
        }
    }
}
