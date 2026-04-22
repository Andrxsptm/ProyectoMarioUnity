using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public static GameEngine Instance;
    public int moneda;
    public int vidas;
    public Canvas canvas;
 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            vidas = 10;
        }
        else
        {
            Destroy(gameObject);
        }
        
        canvas.gameObject.SetActive(false);
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
    }
    public void QuitarVidas()
    {

        vidas--;
        Debug.Log(vidas);
    }
}

