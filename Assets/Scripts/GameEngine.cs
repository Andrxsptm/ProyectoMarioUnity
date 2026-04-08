
using TMPro;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public static GameEngine Instance;
    public TMP_Text monedasText;
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
        monedasText.text = "Monedas: " + moneda;
    }
    public void QuitarVidas()
    {

        vidas--;
        Debug.Log(vidas);
    }
}

