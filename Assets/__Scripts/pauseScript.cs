using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour {
    public bool paused;
	// Use this for initialization
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Pause()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("_Scene_0");
    }
    public void Exit()
    {
        Application.Quit();
    }
  
}
