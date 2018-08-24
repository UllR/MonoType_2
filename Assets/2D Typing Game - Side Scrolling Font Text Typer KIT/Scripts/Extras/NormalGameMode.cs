using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalGameMode : MonoBehaviour {

    public static int lang = 0;

    // Use this for initialization
    void Start () {
        lang = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		//Application.LoadLevel(Application.loadedLevel+2);
		SceneManager.LoadScene(+2);
	}
}
