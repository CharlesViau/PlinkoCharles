using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        source.pitch = Random.Range(0.8f, 1.2f);
        source.Play();
    }
}
