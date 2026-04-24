using System;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    private static string path = Application.persistentDataPath + "/save.json";

    public static void GuardarJuego(string scene)
    {
        SaveData data = new SaveData();

        data.monedas = GameEngine.Instance.moneda;
        data.escenaActual = scene;
        data.vida = GameEngine.Instance.vidas; 
        
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        Debug.Log("Juego guardado en: " + path);
    }

    public static SaveData CargarJuego()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<SaveData>(json);
        }
        return null;
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
