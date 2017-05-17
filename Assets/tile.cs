using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour {

    public GameManager gameManager;
    public AudioClip hit;
    AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        gameManager.Addpoint();
        source.PlayOneShot(hit);
    }
}
