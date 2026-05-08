using UnityEngine;
using UnityEngine.SceneManagement;

public class colliderController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string nombreEscena = SceneManager.GetActiveScene().name;
        switch (nombreEscena)
        {
            case "NivelCero":
                SaveSystem.GuardarJuego("NivelCero");
                SceneManager.LoadScene("NivelCero");
                SceneManager.instance.CargarMusica(AudioManager.instance.musicaNivel1);
                break;

            case "NivelUno":
                SaveSystem.GuardarJuego("NivelUno");
                SceneManager.LoadScene("NivelUno");
                SceneManager.instance.CargarMusica(AudioManager.instance.musicaNivel1);
                break ;


        }
        
        
        
        
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Mario"))
            {
                SceneManager.LoadScene("NivelDos");
            }
        }
    }
}
