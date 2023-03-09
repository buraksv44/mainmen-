using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Slider Slider;
    public Text loadingtxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadingBar());
    }
    public IEnumerator LoadingBar()
    {
       
            
            loadingtxt.text = "YÜKLENÝYOR".ToString();
            Slider.value = Slider.value = 0.25f;
            yield return new WaitForSeconds(1);
            loadingtxt.text = "YÜKLENÝYOR..".ToString();
            Slider.value = Slider.value = 0.50f;
            yield return new WaitForSeconds(1);
            loadingtxt.text = "YÜKLENÝYOR...".ToString();
            Slider.value = Slider.value = 0.75f;
            yield return new WaitForSeconds(1);
            loadingtxt.text = "YÜKLENÝYOR...".ToString();
            Slider.value = Slider.value = 1;
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
}
