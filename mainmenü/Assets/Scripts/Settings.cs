using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Text sound;
    public Slider soundEffect;
    public Camera main;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        main.GetComponent<AudioSource>().volume = soundEffect.value;
        sound.text=soundEffect.GetComponent<Slider>().value.ToString();
        if (Input.GetMouseButton(0)) ;
       
        
    }
    

}
