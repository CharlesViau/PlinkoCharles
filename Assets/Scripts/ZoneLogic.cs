using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class ZoneLogic : MonoBehaviour
{
    private AudioSource source;
    public GameObject audioManager;
    private AudioSource backgroundMusic;
    private bool isGameOver = false;
    // Start is called before the first frame update
    private void Awake()
    {
        source = gameObject.GetComponent<AudioSource>();
        backgroundMusic = audioManager.GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        if (isGameOver && Input.anyKeyDown)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        backgroundMusic.Stop();
        source.Play();

        if (CompareTag("WinCondition"))
        {
            Debug.Log("You Won");
        }
        else
        {
            Debug.Log("You Lose");
        }

        isGameOver = true;
    }
}
