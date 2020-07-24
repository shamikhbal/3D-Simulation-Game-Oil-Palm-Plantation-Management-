using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour{
    public Text playerName;
    public AudioSource career;
    public AudioSource turorial;
    public AudioSource exit;
    public AudioSource delete;
    public AudioClip clickFx;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
        if (PlayerPrefs.GetString("name") == null)
        {
            SceneManager.LoadScene("Name");
        }
        else
        {
            playerName.text = PlayerPrefs.GetString("name");
        }
    }

    public void Career()
    {
        career.PlayOneShot(clickFx);
        StartCoroutine(careerScene());
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Tutorial()
    {
        turorial.PlayOneShot(clickFx);
        StartCoroutine(tutorialScene());
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void QuitGame()
    {
        exit.PlayOneShot(clickFx);
        StartCoroutine(exitGame());
        
    }

    public void Delete()
    {
        delete.PlayOneShot(clickFx);
        StartCoroutine(deletePlayer());
        PlayerPrefs.DeleteKey("name");
        
    }

    IEnumerator careerScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Career");
    }
    IEnumerator tutorialScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Tutorial");
    }
    IEnumerator exitGame()
    {
        yield return new WaitForSeconds(0.5f);
        PlayerPrefs.Save();
        Application.Quit();
    }
    IEnumerator deletePlayer()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Name");
    }
}
