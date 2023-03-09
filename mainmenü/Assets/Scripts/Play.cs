using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public Image playButton,settingsButton;
    public Animator anim;
    public GameObject sahne, homeButton;
    public GameObject settingmain,moneymain,shopmain,questmain,emailmain,carmain,levelmain;
    public AudioSource playsound, levelsond, carsound, emailsound, questsound, shopsound, moneysound, scoresound, settingssound, homesound;
    public AudioClip soundcilp;
    private void Start()
    {
        StartCoroutine(Effect());
    }
    

    public void PlayButton()
    {
        playsound.Stop();
        playsound.PlayOneShot(soundcilp);
        StartCoroutine(Playpass());
       


    }
    public void SettingsButton()
    {
        
        StartCoroutine(Settingspass());
        moneymain.SetActive(false);
        levelmain.SetActive(false);
        emailmain.SetActive(false);
        carmain.SetActive(false);
        questmain.SetActive(false);
        shopmain.SetActive(false);
       


    }
   



     public void HomeButton()
    {
        homesound.Stop();
        homesound.PlayOneShot(soundcilp);
        StartCoroutine(Homepass());
       


    }  public void MoneyButton()
    {
        moneysound.Stop();
        moneysound.PlayOneShot(soundcilp);
        StartCoroutine(Moneypass());
        levelmain.SetActive(false);
        emailmain.SetActive(false);
        carmain.SetActive(false);
        questmain.SetActive(false);
        shopmain.SetActive(false);
        settingmain.SetActive(false);


    }
    public void ShopButton()
    {
        shopsound.Stop();
        shopsound.PlayOneShot(soundcilp);
        StartCoroutine(Shoppass());
        levelmain.SetActive(false);
        emailmain.SetActive(false);
        carmain.SetActive(false);
        questmain.SetActive(false);
        moneymain.SetActive(false);
        settingmain.SetActive(false);

    }
    public void QuestButton()
    {
        questsound.Stop();
        questsound.PlayOneShot(soundcilp);
        StartCoroutine(Questpass());
        levelmain.SetActive(false);
        emailmain.SetActive(false);
        carmain.SetActive(false);
        shopmain.SetActive(false);
        moneymain.SetActive(false);
        settingmain.SetActive(false);


    }
    public void EmailButton()
    {
        emailsound.Stop();
        emailsound.PlayOneShot(soundcilp);
        StartCoroutine(Emailpass());
        levelmain.SetActive(false);
        carmain.SetActive(false);
        questmain.SetActive(false);
        shopmain.SetActive(false);
        moneymain.SetActive(false);
        settingmain.SetActive(false);


    }
    public void CarButton()
    {
        carsound.Stop();
        carsound.PlayOneShot(soundcilp);
        StartCoroutine(Carpass());
        levelmain.SetActive(false);
        emailmain.SetActive(false);
        questmain.SetActive(false);
        shopmain.SetActive(false);
        moneymain.SetActive(false);
        settingmain.SetActive(false);

    }
    public void LevelButton()
    {
        levelsond.Stop();
        levelsond.PlayOneShot(soundcilp);
        StartCoroutine(Levelpass());
        carmain.SetActive(false);
        emailmain.SetActive(false);
        questmain.SetActive(false);
        shopmain.SetActive(false);
        moneymain.SetActive(false);
        settingmain.SetActive(false);



    }
    IEnumerator Effect()
    {
        sahne.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        sahne.SetActive(false);

    }

      IEnumerator Playpass()
    {
        playButton.color = Color.blue;
        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
     IEnumerator Settingspass()
    {
        settingssound.Stop();
        settingssound.PlayOneShot(soundcilp);
        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled=false;
        homeButton.SetActive(true);
        settingmain.SetActive(true);
        sahne.SetActive(false) ;


    } IEnumerator Homepass()
    {
        homesound.Stop();
        homesound.PlayOneShot(soundcilp);
        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled=(true);
        homeButton.SetActive(false);
        settingmain.SetActive(false);
        sahne.SetActive(false);
        moneymain.SetActive(false);
        shopmain.SetActive(false);
        questmain.SetActive(false);
        emailmain.SetActive(false);
        carmain.SetActive(false);
        levelmain.SetActive(false);
    }

    IEnumerator Moneypass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        moneymain.SetActive(true);
        sahne.SetActive(false);
        


    }
    IEnumerator Shoppass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        shopmain.SetActive(true);
        sahne.SetActive(false);


    }
    IEnumerator Questpass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        questmain.SetActive(true);
        sahne.SetActive(false);


    }
    IEnumerator Emailpass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        emailmain.SetActive(true);
        sahne.SetActive(false);


    }
    IEnumerator Carpass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        carmain.SetActive(true);
        sahne.SetActive(false);


    }
    IEnumerator Levelpass()
    {

        sahne.SetActive(true);
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        settingsButton.enabled = false;
        homeButton.SetActive(true);
        levelmain.SetActive(true);
        sahne.SetActive(false);


    }

}

