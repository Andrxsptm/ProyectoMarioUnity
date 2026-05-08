using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Sources")]
    public AudioSource musicSource;

    [Header ("Clips")]
    public AudioClip moneda;
    public AudioClip musicaMenu;
    public AudioClip musicaNivel1;
    public AudioClip musicaNivel2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        musicSource.PlayOneShot(clip);
    }

    public void CambiarMusica(AudioClip nuevoClip)
    {
        if (musicSource.clip == nuevoClip) return;

        musicSource.Stop();
        musicSource.clip = nuevoClip;
        musicSource.loop = true;
        musicSource.Play();
    }

}
