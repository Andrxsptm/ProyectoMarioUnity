using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void Jugar()
    {
       SceneManager.LoadScene("NivelCero");
       GameEngine.Instance.canvas.gameObject.SetActive(true);
    }
    public void Continuar()
    {
        SaveData data = SaveSystem.CargarJuego();
        if (data != null)
        {
            GameEngine.Instance.moneda = data.monedas;
            GameEngine.Instance.vidas = data.vida;
            SceneManager.LoadScene(data.escenaActual);
        }
        else
        {
            SceneManager.LoadScene("NivelCero");
        }
    }
        
    
    public void Salir()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      
}
