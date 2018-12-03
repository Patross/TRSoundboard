using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoBack()
    {
        //Gets current scene so we  can grab the name
        Scene scene = SceneManager.GetActiveScene();

        //Compares the current scene name and redirects accordingly
        if (scene.name == "Scream Sounds") { SceneManager.LoadScene("Soundboard"); }
        if (scene.name == "Soundboard") { SceneManager.LoadScene("MainMenu"); }

    }

}
