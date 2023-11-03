using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Ass3Scene");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
