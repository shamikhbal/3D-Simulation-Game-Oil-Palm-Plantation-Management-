using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text player;
    public AudioSource myFx;
    public AudioClip clickFx;

    private void Start()
    {
        player.text = "Player : "+PlayerPrefs.GetString("name");
    }

    public void Mainmenu()
    {
        myFx.PlayOneShot(clickFx);
        StartCoroutine(mainMenuScene());
    }

    IEnumerator mainMenuScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Menu");
    }
}
