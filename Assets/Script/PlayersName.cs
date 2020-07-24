using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayersName : MonoBehaviour
{
    public InputField playerName;
    public AudioSource myFx;
    public AudioClip clickFx;

    private void Start()
    {
        string str = PlayerPrefs.GetString("name", null);
        if (string.IsNullOrEmpty(str) == true)
        {
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void saveButton()
    {
        myFx.PlayOneShot(clickFx);
        PlayerPrefs.SetString("name", playerName.text);
        StartCoroutine(mainMenuScene());
    }

    IEnumerator mainMenuScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
