using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;



public class OyunConrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    int score=0;
    public Text text;
    bool oyunBittiKontrol = false;
    bool yenidenBaslaKontrol = false;
    int enYüksekPuan = 0;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontrol)
        {
            SceneManager.LoadScene("level");
        }
        if (score > enYüksekPuan)
        {
            enYüksekPuan = score;
            PlayerPrefs.SetInt("kayit", enYüksekPuan);

        }
        Invoke("anaMenuyeDon", 2);
    }
    void anaMenuyeDon()
    {
        Scenemanager.LoadScene("anaMenu");
    }


    void Start()
    {
        score = 0;
        text.text = "Score= " + score;
        StartCoroutine(olustur());
        enYüksekPuan = PlayerPrefs.GetInt("kayit");
        Debug.Log("enyüksek puan "+enYüksekPuan);
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for(int i=0; i < 15; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.7f);
            }
            yield return new WaitForSeconds(5.0f);
            if (oyunBittiKontrol)
            {
                yenidenBaslaKontrol = true;
                break;
            }
        }
    }


    public void ScoreArttır(int gelenScore)
    {
        score += gelenScore;
        text.text = "Score= " + score;
        Debug.Log(score);
    }
    public void oyunBitti()
    {
        Debug.Log("Oyun Bitti");
        oyunBittiKontrol = true; 
    }
}
