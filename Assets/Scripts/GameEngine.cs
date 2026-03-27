using JetBrains.Annotations;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public static GameEngine Instance;
    public int moneda;
    public int vidas;
 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            vidas = 10;
        }
        else
        {

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SumarMonedas()
    {
        moneda++;
        Debug.Log(moneda);
    }
    public void QuitarVidas()
    {

        vidas--;
        Debug.Log(vidas);
    }
}

