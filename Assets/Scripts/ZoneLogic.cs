using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ZoneLogic : MonoBehaviour
{
    private AudioSource source;
    public GameObject audioManager;
    private AudioSource backgroundMusic;

    // Start is called before the first frame update
    private void Awake()
    {
        source = gameObject.GetComponent<AudioSource>();
        backgroundMusic = audioManager.GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        backgroundMusic.Stop();
        source.Play();
        if (tag == "WinCondition")
        {
            Debug.Log("You Won");
        }
        else
        {
            Debug.Log("You Lose");
        }
    }
}
