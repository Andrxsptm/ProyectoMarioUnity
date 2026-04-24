using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TMP_Text monedasText;
    public TMP_Text vidaText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monedasText.text = "monedas: " + GameEngine.Instance.moneda;
        vidaText.text = "vidas: " + GameEngine.Instance.vidas;
    }
}
