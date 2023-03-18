using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kostebek : MonoBehaviour
{
    [SerializeField]
    float zamanal;
    public Button vur;
    int muzik_sec;
    public GameObject kst,gectinpanel,tekrarlapanel,exitpanel,yandinpanel;
    float kes;
    public AudioSource[] au;
    public Text timee;
    List<int> list = new List<int>();
    float score,pozisyon_y;
    public Text skor;
    public SpriteRenderer kost;
    public Sprite normal, cut;
    float time1;

    void Start()
    {
        time1 = 0;
        gectinpanel.SetActive(false);tekrarlapanel.SetActive(false);exitpanel.SetActive(false);
        kost.sprite = normal;
        pozisyon_y = kst.transform.position.y;
        score = 0;
        muzik_sec = Random.Range(1, 3);
        if (muzik_sec == 1)
        {
            for(int iiii=0; iiii < 30; iiii++)
            {
                au[iiii + 60] = au[iiii];
                au[iiii] = au[iiii+30];
                au[iiii + 30] = au[iiii + 60];

            }   
        }
        GenerateRandom();
        
        for (int ii = 0; ii < 10; ii++)
        {
            au[list[ii]] = au[31+ii];
            
        }
        au[0].PlayDelayed(2.0f);  au[1].PlayDelayed(7.0f);  au[2].PlayDelayed(12.0f); au[3].PlayDelayed(17.0f);  au[4].PlayDelayed(22.0f); au[5].PlayDelayed(27.0f); au[6].PlayDelayed(32.0f);
        au[7].PlayDelayed(37.0f);  au[8].PlayDelayed(42.0f);  au[9].PlayDelayed(47.0f);  au[10].PlayDelayed(52.0f); au[11].PlayDelayed(57.0f); au[12].PlayDelayed(62.0f); au[13].PlayDelayed(67.0f);
        au[14].PlayDelayed(72.0f); au[15].PlayDelayed(77.0f); au[16].PlayDelayed(82.0f); au[17].PlayDelayed(87.0f); au[18].PlayDelayed(92.0f); au[19].PlayDelayed(97.0f); au[20].PlayDelayed(102.0f);
        au[21].PlayDelayed(107.0f); au[22].PlayDelayed(112.0f); au[23].PlayDelayed(117.0f); au[24].PlayDelayed(122.0f); au[25].PlayDelayed(127.0f); au[26].PlayDelayed(132.0f); au[27].PlayDelayed(137.0f);
        au[28].PlayDelayed(142.0f); au[29].PlayDelayed(147.0f); 
        vur.onClick.AddListener(taskonclick);
    }

    public void taskonclick()
    {
        zamanal = time1;
        if ((zamanal >= 2+5*list[0] && zamanal <= 2+5*list[0] + 5)|| (zamanal >= 2 + 5 * list[1] && zamanal <= 2 + 5 * list[1] + 5) || (zamanal >= 2 + 5 * list[2] && zamanal <= 2 + 5 * list[2] + 5)
            || (zamanal >= 2 + 5 * list[3] && zamanal <= 2 + 5 * list[3] + 5) || (zamanal >= 2 + 5 * list[4] && zamanal <= 2 + 5 * list[4] + 5) || (zamanal >= 2 + 5 * list[5] && zamanal <= 2 + 5 * list[5] + 5)
            || (zamanal >= 2 + 5 * list[6] && zamanal <= 2 + 5 * list[6] + 5) || (zamanal >= 2 + 5 * list[7] && zamanal <= 2 + 5 * list[7] + 5) || (zamanal >= 2 + 5 * list[8] && zamanal <= 2 + 5 * list[8] + 5)
            || (zamanal >= 2 + 5 * list[9] && zamanal <= 2 + 5 * list[9] + 5)) //BURAYI TAMAMLA DEVAMIYLA
        {
            score += 1;
        }
    }
    void GenerateRandom()
    {
        for (int j = 0; j < 10; j++)
        {
            int Rand = Random.Range(3, 29);
            while (list.Contains(Rand))
            {
                Rand = Random.Range(3, 29);
            }
            list.Add(Rand);
            
        }
        list.Sort();
    }
    void Update()
    {
        time1 += Time.deltaTime;
        skor.text = "Skor: " + score.ToString();
        if (time1>= kes+2)
        {
            //kst.transform.position = new Vector2(kst.transform.position.x, pozisyon_y);
            kost.sprite = normal;
        }
        timee.text = Time.time.ToString("F0");
        if (time1 > 150)
        {
            if (score < 3) { yandinpanel.SetActive(true); }
            else if (score >= 3 && score < 7) { tekrarlapanel.SetActive(true); }
            else if (score >= 7) { gectinpanel.SetActive(true); }
        }
    }
    public void tiklama()
    {
        pozisyon_y = kst.transform.position.y;
        //kst.transform.position = new Vector2(kst.transform.position.x, -1);
        kes = Time.time;
        kost.sprite = cut;
    }
    public void anamenu()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void tekrarla_k1()
    {
        SceneManager.LoadScene("k1");
    }
    public void tekrarla_k2()
    {
        SceneManager.LoadScene("k2");
    }
    public void tekrarla_k3()
    {
        SceneManager.LoadScene("k3");
    }
    public void yenibolum_k1()
    {
        SceneManager.LoadScene("o1");
    }
    public void yenibolum_k2()
    {
        SceneManager.LoadScene("o2");
    }
    public void yenibolum_k3()
    {
        SceneManager.LoadScene("o3");
    }
    public void eskibolum_k2()
    {
        SceneManager.LoadScene("z1");
    }
    public void eskibolum_k3()
    {
        SceneManager.LoadScene("z2");
    }
    public void cikis()
    {
        exitpanel.SetActive(true);
    }
}
