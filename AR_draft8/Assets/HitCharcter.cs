using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCharcter : MonoBehaviour {

    Renderer rend;
    public GameObject sphere, spawn;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
        sphere.transform.position = spawn.transform.position;
	}
}
