using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AnaMenu : MonoBehaviour
{
    public Text puanText;
    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("kayit");
        puanText.text = "En Yuksek Puan: " + enYuksekPuan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void oyunaGit()
    {
        SceneManager.LoadScene("level");
    }
    public void oyundanCik()
    {
        Application.Quit();
    }
}
