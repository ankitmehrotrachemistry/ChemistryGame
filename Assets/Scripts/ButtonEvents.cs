using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public GameObject NotesText;

    public void LoadOnPlayButton()
    {
        SceneManager.LoadScene("ClassSelection");
    }

    public void NotesButton()
    {
        SceneManager.LoadScene("ClassSelection");
        NotesText.SetActive(true);
    }

    public void ObjectiveBackButton()
    {
        SceneManager.LoadScene("ClassSelection");
    }

    public void SubjectiveBackButton()
    {
        SceneManager.LoadScene("ClassSelection");
    }
    public void BackButtonClick()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void JEEButtonClick()
    {
        SceneManager.LoadScene("Objective");
    }

    public void NEETButtonClick()
    {
        SceneManager.LoadScene("Objective");
    }

    public void Class11ButtonClicked()
    {
        SceneManager.LoadScene("Subjective");
    }
    public void Class12ButtonClicked()
    {
        SceneManager.LoadScene("Subjective");
    }
    void Update()
    {
        
    }
}
