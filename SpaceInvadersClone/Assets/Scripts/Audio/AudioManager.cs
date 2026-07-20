using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [SerializeField] AudioClip backgroundMusic;
    public AudioClip enemyHit;
    public AudioClip playerHit;
    public AudioClip enemyShoot;
    public AudioClip playerShoot;
    void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void playSFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
