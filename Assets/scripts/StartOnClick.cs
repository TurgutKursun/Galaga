using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class StartOnClick : MonoBehaviour
{
    public AudioSource btnAudio;
    
    public void Clicked()
    {
        DontDestroyOnLoad(this);
        btnAudio.Play();
        SceneManager.LoadScene("Play");
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
