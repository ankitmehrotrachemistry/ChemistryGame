using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public void LoadOnPlayButton()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene("ClassSelection");
    }

    public void Class12ButtonClicked()
    {
        SceneManager.LoadScene("GameChapters");
    }
    void Update()
    {
        
    }
}
