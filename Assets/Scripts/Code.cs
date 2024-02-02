using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("HighestScore", 500);

    float enYuksek = PlayerPrefs.GetFloat("EnYuksekSkor"); 
    PlayerPrefs.SetFloat("EnYuksek", 750);
    float enYuksekSkor= PlayerPrefs.GetFloat("EnYuksek", 1000);

        // print("Highest score: "+ highestscore);

    PlayerPrefs.SetInt("canSayisi", 10);
    //print(PlayerPrefs.GetInt("canSayisi", 5));

    PlayerPrefs.SetString("PlayerName", "Beyza");
    //print(PlayerPrefs.GetString("PlayerName","player 1"))
     
    PlayerPrefs.DeleteKey("PlayerName");
    print(PlayerPrefs.GetString("PlayerName", "player 1"));
    PlayerPrefs.DeleteAll();
    print(PlayerPrefs.GetFloat("EnYuksek",999));
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
