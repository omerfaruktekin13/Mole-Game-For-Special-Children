using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class zor : MonoBehaviour
{
    
    [SerializeField]
    

    public Button solbuton,ortabuton,sagbuton;
    public Text skoretabela,zamantext;
    int s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, score;
    public AudioSource[] aud;
    float zamanal1,zamanal2,zamanal3,kes,gercekzaman;
    bool check;
    public SpriteRenderer kost1, kost2,kost3;
    public Sprite normal, cut;
    public GameObject gectinpanel, tekrarlapanel, exitpanel, yandinpanel;

    // Start is called before the first frame update
    void Start()
    {
        check = true;
        score = 0;
        gercekzaman = 0;
        kost1.sprite = cut;
        kost2.sprite = cut;
        kost3.sprite = cut;
        s1 = Random.Range(0, 2); s2 = Random.Range(0, 2); s3 = Random.Range(0, 2); s4 = Random.Range(0, 2); s5 = Random.Range(0, 2); s6 = Random.Range(0, 2); s7 = Random.Range(0, 2); s8 = Random.Range(0, 2);
        s9 = Random.Range(0, 2); s10 = Random.Range(0, 2);
        e1 = Random.Range(0, 3); e2 = Random.Range(0, 3); e3 = Random.Range(0, 3); e4 = Random.Range(0, 3); e5 = Random.Range(0, 3); e6 = Random.Range(0, 3); e7 = Random.Range(0, 3); e8 = Random.Range(0, 3);
        e9 = Random.Range(0, 3); e10 = Random.Range(0, 3);
        if (s1 == 0) {  if (e1 == 0) { aud[0].PlayDelayed(0 + 1.5f); aud[2].PlayDelayed(0 + 3f); aud[3].PlayDelayed(0 + 4.5f); } else if(e1==1) { aud[2].PlayDelayed(0 + 1.5f); aud[0].PlayDelayed(0 + 3f); aud[3].PlayDelayed(0 + 4.5f); } else if (e1 == 2) { aud[2].PlayDelayed(0 + 1.5f); aud[3].PlayDelayed(0 + 3f); aud[0].PlayDelayed(0 + 4.5f); } }
        else if (s1 == 1) { if (e1 == 0) { aud[2].PlayDelayed(0 + 1.5f); aud[0].PlayDelayed(0 + 3f); aud[1].PlayDelayed(0 + 4.5f); } else if (e1 == 1) { aud[0].PlayDelayed(0 + 1.5f); aud[2].PlayDelayed(0 + 3f); aud[1].PlayDelayed(0 + 4.5f); } else if (e1 == 2) { aud[0].PlayDelayed(0 + 1.5f); aud[1].PlayDelayed(0 + 3f); aud[2].PlayDelayed(0 + 4.5f); } }

        if (s2 == 0) { if (e2 == 0) { aud[4].PlayDelayed(10 + 1.5f); aud[6].PlayDelayed(10 + 3f); aud[7].PlayDelayed(10 + 4.5f); } else if (e2 == 1) { aud[6].PlayDelayed(10 + 1.5f); aud[4].PlayDelayed(10 + 3f); aud[7].PlayDelayed(10 + 4.5f); } else if (e2 == 2) { aud[6].PlayDelayed(10 + 1.5f); aud[7].PlayDelayed(10 + 3f); aud[4].PlayDelayed(10 + 4.5f); } }
        else if (s2 == 1) { if (e2 == 0) { aud[6].PlayDelayed(10 + 1.5f); aud[4].PlayDelayed(10 + 3f); aud[5].PlayDelayed(10 + 4.5f); } else if (e2 == 1) { aud[4].PlayDelayed(10 + 1.5f); aud[6].PlayDelayed(10 + 3f); aud[5].PlayDelayed(10 + 4.5f); } else if (e2 == 2) { aud[4].PlayDelayed(10 + 1.5f); aud[5].PlayDelayed(10 + 3f); aud[6].PlayDelayed(10 + 4.5f); } }

        if (s3 == 0) { if (e3 == 0) { aud[8].PlayDelayed(20 + 1.5f); aud[10].PlayDelayed(20 + 3f); aud[11].PlayDelayed(20 + 4.5f); } else if (e3 == 1) { aud[10].PlayDelayed(20 + 1.5f); aud[8].PlayDelayed(20 + 3f); aud[11].PlayDelayed(20 + 4.5f); } else if (e3 == 2) { aud[10].PlayDelayed(20 + 1.5f); aud[11].PlayDelayed(20 + 3f); aud[8].PlayDelayed(20 + 4.5f); } }
        else if (s3 == 1) { if (e3 == 0) { aud[10].PlayDelayed(20 + 1.5f); aud[8].PlayDelayed(20 + 3f); aud[9].PlayDelayed(20 + 4.5f); } else if (e3 == 1) { aud[8].PlayDelayed(20 + 1.5f); aud[10].PlayDelayed(20 + 3f); aud[9].PlayDelayed(20 + 4.5f); } else if (e3 == 2) { aud[8].PlayDelayed(20 + 1.5f); aud[9].PlayDelayed(20 + 3f); aud[10].PlayDelayed(20 + 4.5f); } }

        if (s4 == 0) { if (e4 == 0) { aud[12].PlayDelayed(30 + 1.5f); aud[14].PlayDelayed(30 + 3f); aud[15].PlayDelayed(30 + 4.5f); } else if (e4 == 1) { aud[14].PlayDelayed(30 + 1.5f); aud[12].PlayDelayed(30 + 3f); aud[15].PlayDelayed(30 + 4.5f); } else if (e4 == 2) { aud[14].PlayDelayed(30 + 1.5f); aud[15].PlayDelayed(30 + 3f); aud[12].PlayDelayed(30 + 4.5f); } }
        else if (s4 == 1) { if (e4 == 0) { aud[14].PlayDelayed(30 + 1.5f); aud[12].PlayDelayed(30 + 3f); aud[13].PlayDelayed(30 + 4.5f); } else if (e4 == 1) { aud[12].PlayDelayed(30 + 1.5f); aud[14].PlayDelayed(30 + 3f); aud[13].PlayDelayed(30 + 4.5f); } else if (e4 == 2) { aud[12].PlayDelayed(30 + 1.5f); aud[13].PlayDelayed(30 + 3f); aud[14].PlayDelayed(30 + 4.5f); } }

        if (s5 == 0) { if (e5 == 0) { aud[16].PlayDelayed(40 + 1.5f); aud[18].PlayDelayed(40 + 3f); aud[19].PlayDelayed(40 + 4.5f); } else if (e5 == 1) { aud[18].PlayDelayed(40 + 1.5f); aud[16].PlayDelayed(40 + 3f); aud[19].PlayDelayed(40 + 4.5f); } else if (e5 == 2) { aud[18].PlayDelayed(40 + 1.5f); aud[19].PlayDelayed(40 + 3f); aud[16].PlayDelayed(40 + 4.5f); } }
        else if (s5 == 1) { if (e5 == 0) { aud[18].PlayDelayed(40 + 1.5f); aud[16].PlayDelayed(40 + 3f); aud[17].PlayDelayed(40 + 4.5f); } else if (e5 == 1) { aud[16].PlayDelayed(40 + 1.5f); aud[18].PlayDelayed(40 + 3f); aud[17].PlayDelayed(40 + 4.5f); } else if (e5 == 2) { aud[16].PlayDelayed(40 + 1.5f); aud[17].PlayDelayed(40 + 3f); aud[18].PlayDelayed(40 + 4.5f); } }

        if (s6 == 0) { if (e6== 0) { aud[20].PlayDelayed(50 + 1.5f); aud[22].PlayDelayed(50 + 3f); aud[23].PlayDelayed(50 + 4.5f); } else if (e6 == 1) { aud[22].PlayDelayed(50 + 1.5f); aud[20].PlayDelayed(50 + 3f); aud[23].PlayDelayed(50 + 4.5f); } else if (e6 == 2) { aud[22].PlayDelayed(50 + 1.5f); aud[23].PlayDelayed(50 + 3f); aud[20].PlayDelayed(50 + 4.5f); } }
        else if (s6 == 1) { if (e6 == 0) { aud[22].PlayDelayed(50 + 1.5f); aud[20].PlayDelayed(50 + 3f); aud[21].PlayDelayed(50 + 4.5f); } else if (e6 == 1) { aud[20].PlayDelayed(50 + 1.5f); aud[22].PlayDelayed(50 + 3f); aud[21].PlayDelayed(50 + 4.5f); } else if (e6 == 2) { aud[20].PlayDelayed(50 + 1.5f); aud[21].PlayDelayed(50 + 3f); aud[22].PlayDelayed(50 + 4.5f); } }

        if (s7 == 0) { if (e7 == 0) { aud[24].PlayDelayed(60 + 1.5f); aud[26].PlayDelayed(60 + 3f); aud[27].PlayDelayed(60 + 4.5f); } else if (e7 == 1) { aud[26].PlayDelayed(60 + 1.5f); aud[24].PlayDelayed(60 + 3f); aud[27].PlayDelayed(60 + 4.5f); } else if (e7 == 2) { aud[26].PlayDelayed(60 + 1.5f); aud[27].PlayDelayed(60 + 3f); aud[24].PlayDelayed(60 + 4.5f); } }
        else if (s7 == 1) { if (e7 == 0) { aud[26].PlayDelayed(60 + 1.5f); aud[24].PlayDelayed(60 + 3f); aud[25].PlayDelayed(60 + 4.5f); } else if (e7 == 1) { aud[24].PlayDelayed(60 + 1.5f); aud[26].PlayDelayed(60 + 3f); aud[25].PlayDelayed(60 + 4.5f); } else if (e7 == 2) { aud[24].PlayDelayed(60 + 1.5f); aud[25].PlayDelayed(60 + 3f); aud[26].PlayDelayed(60 + 4.5f); } }

        if (s8== 0) { if (e8 == 0) { aud[28].PlayDelayed(70 + 1.5f); aud[30].PlayDelayed(70 + 3f); aud[31].PlayDelayed(70 + 4.5f); } else if (e8 == 1) { aud[30].PlayDelayed(70 + 1.5f); aud[28].PlayDelayed(70 + 3f); aud[31].PlayDelayed(70 + 4.5f); } else if (e8 == 2) { aud[30].PlayDelayed(70 + 1.5f); aud[31].PlayDelayed(70 + 3f); aud[28].PlayDelayed(70 + 4.5f); } }
        else if (s8 == 1) { if (e8 == 0) { aud[30].PlayDelayed(70 + 1.5f); aud[28].PlayDelayed(70 + 3f); aud[29].PlayDelayed(70 + 4.5f); } else if (e8 == 1) { aud[28].PlayDelayed(70 + 1.5f); aud[30].PlayDelayed(70 + 3f); aud[29].PlayDelayed(70 + 4.5f); } else if (e8 == 2) { aud[28].PlayDelayed(70 + 1.5f); aud[29].PlayDelayed(70 + 3f); aud[30].PlayDelayed(70 + 4.5f); } }

        if (s9 == 0) { if (e9== 0) { aud[32].PlayDelayed(80 + 1.5f); aud[34].PlayDelayed(80 + 3f); aud[35].PlayDelayed(80 + 4.5f); } else if (e9 == 1) { aud[34].PlayDelayed(80 + 1.5f); aud[32].PlayDelayed(80 + 3f); aud[35].PlayDelayed(80 + 4.5f); } else if (e9 == 2) { aud[34].PlayDelayed(80 + 1.5f); aud[35].PlayDelayed(80 + 3f); aud[32].PlayDelayed(80 + 4.5f); } }
        else if (s9 == 1) { if (e9 == 0) { aud[34].PlayDelayed(80 + 1.5f); aud[32].PlayDelayed(80 + 3f); aud[33].PlayDelayed(80 + 4.5f); } else if (e9 == 1) { aud[32].PlayDelayed(80 + 1.5f); aud[34].PlayDelayed(80 + 3f); aud[33].PlayDelayed(80 + 4.5f); } else if (e9 == 2) { aud[32].PlayDelayed(80 + 1.5f); aud[33].PlayDelayed(80 + 3f); aud[34].PlayDelayed(80 + 4.5f); } }

        if (s10 == 0) { if (e10 == 0) { aud[36].PlayDelayed(90 + 1.5f); aud[38].PlayDelayed(90 + 3f); aud[39].PlayDelayed(90 + 4.5f); } else if (e10 == 1) { aud[38].PlayDelayed(90 + 1.5f); aud[36].PlayDelayed(90 + 3f); aud[39].PlayDelayed(90 + 4.5f); } else if (e10 == 2) { aud[38].PlayDelayed(90 + 1.5f); aud[39].PlayDelayed(90 + 3f); aud[36].PlayDelayed(90 + 4.5f); } }
        else if (s10 == 1) { if (e10 == 0) { aud[38].PlayDelayed(90 + 1.5f); aud[36].PlayDelayed(90 + 3f); aud[37].PlayDelayed(90 + 4.5f); } else if (e10 == 1) { aud[36].PlayDelayed(90 + 1.5f); aud[38].PlayDelayed(90 + 3f); aud[37].PlayDelayed(90 + 4.5f); } else if (e10 == 2) { aud[36].PlayDelayed(90 + 1.5f); aud[37].PlayDelayed(90 + 3f); aud[38].PlayDelayed(90 + 4.5f); } }
        solbuton.onClick.AddListener(taskonclicksol);
        ortabuton.onClick.AddListener(taskonclickorta);
        sagbuton.onClick.AddListener(taskonclicksag);
    }

    void Update()
    {
        gercekzaman += Time.deltaTime;
        zamantext.text = (gercekzaman % 10).ToString("F0");
        skoretabela.text = "Score: " + score.ToString();
        if (gercekzaman % 10 > 1.5f&&check==true)
        {
            kost1.sprite = normal;
            if (gercekzaman % 10 > 3f&&check == true)
            {
                kost2.sprite = normal;
                if (gercekzaman % 10 > 4.5f&&check == true)
                {
                    kost3.sprite = normal;
                }
            }
        }
        else
        {
            kost1.sprite = cut; kost2.sprite= cut;kost3.sprite= cut;
        }
        if (gercekzaman > 100)
        {
            if (score < 3) { yandinpanel.SetActive(true); }
            else if (score >= 3 && score < 7) { tekrarlapanel.SetActive(true); }
            else if (score >= 7) { gectinpanel.SetActive(true); }
        }
    }
    public void taskonclicksol()   
    {         
        zamanal1 = gercekzaman;
        if (zamanal1 >= 5 && zamanal1 <= 10&&e1==0) {score += 1;  }
        else if (zamanal1 >= 15 && zamanal1 <= 20 && e2 == 0) { score += 1; }
        else if (zamanal1 >= 25 && zamanal1 <= 30 && e3 == 0) { score += 1; }
        else if (zamanal1 >= 35 && zamanal1 <= 40 && e4 == 0) { score += 1; }
        else if (zamanal1 >= 45 && zamanal1 <= 50 && e5 == 0) { score += 1; }
        else if (zamanal1 >= 55 && zamanal1 <= 60 && e6 == 0) { score += 1; }
        else if (zamanal1 >= 65 && zamanal1 <= 70 && e7 == 0) { score += 1; }
        else if (zamanal1 >= 75 && zamanal1 <= 80 && e8 == 0) { score += 1; }
        else if (zamanal1 >= 85 && zamanal1 <= 90 && e9 == 0) { score += 1; }
        else if (zamanal1 >= 95 && zamanal1 <= 100 && e10 == 0) { score += 1; }


    }
    public void taskonclickorta()
    {
        zamanal2 = gercekzaman;
        if (zamanal2 >= 5 && zamanal2 <= 10 && e1 == 1) { score += 1; }
        else if (zamanal2 >= 15 && zamanal2 <= 20 && e2 == 1) { score += 1; }
        else if (zamanal2 >= 25 && zamanal2 <= 30 && e3 == 1) { score += 1; }
        else if (zamanal2 >= 35 && zamanal2 <= 40 && e4 == 1) { score += 1; }
        else if (zamanal2 >= 45 && zamanal2 <= 50 && e5 == 1) { score += 1; }
        else if (zamanal2 >= 55 && zamanal2 <= 60 && e6 == 1) { score += 1; }
        else if (zamanal2 >= 65 && zamanal2 <= 70 && e7 == 1) { score += 1; }
        else if (zamanal2 >= 75 && zamanal2 <= 80 && e8 == 1) { score += 1; }
        else if (zamanal2 >= 85 && zamanal2 <= 90 && e9 == 1) { score += 1; }
        else if (zamanal2 >= 95 && zamanal2 <= 100 && e10 == 1) { score += 1; }
    }
    public void taskonclicksag()
    {      
        zamanal3 = gercekzaman;
        if(zamanal3 >= 5 && zamanal3 <= 10 && e1 == 0) { score += 1; }
        else if (zamanal3 >= 15 && zamanal3 <= 20 && e2 == 2) { score += 1; }
        else if (zamanal3 >= 25 && zamanal3 <= 30 && e3 == 2) { score += 1; }
        else if (zamanal3 >= 35 && zamanal3 <= 40 && e4 == 2) { score += 1; }
        else if (zamanal3 >= 45 && zamanal3 <= 50 && e5 == 2) { score += 1; }
        else if (zamanal3 >= 55 && zamanal3 <= 60 && e6 == 2) { score += 1; }
        else if (zamanal3 >= 65 && zamanal3 <= 70 && e7 == 2) { score += 1; }
        else if (zamanal3 >= 75 && zamanal3 <= 80 && e8 == 2) { score += 1; }
        else if (zamanal3 >= 85 && zamanal3 <= 90 && e9 == 2) { score += 1; }
        else if (zamanal3 >= 95 && zamanal3 <= 100 && e10 == 2) { score += 1; }
    }
    public void soltiklama()
    {
        check = false;
        kost1.sprite = cut;
        check = true;

    }
    public void ortatiklama()
    {
        check = false;
        kost2.sprite = cut;
       
        check = true;
    }
    public void sagtiklama()
    {
        check = false;
        kost3.sprite = cut;
        check = true;
    }
    public void anamenu()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void tekrarla_z1()
    {
        SceneManager.LoadScene("z1");
    }
    public void tekrarla_z2()
    {
        SceneManager.LoadScene("z2");
    }
    public void tekrarla_z3()
    {
        SceneManager.LoadScene("z3");
    }
    public void yenibolum_z1()
    {
        SceneManager.LoadScene("k2");
    }
    public void yenibolum_z2()
    {
        SceneManager.LoadScene("k3");
    }
  
    public void eskibolum_z1()
    {
        SceneManager.LoadScene("o1");
    }
    public void eskibolum_z2()
    {
        SceneManager.LoadScene("o2");
    }
    public void eskibolum_z3()
    {
        SceneManager.LoadScene("o3");
    }
    public void cikis()
    {
        exitpanel.SetActive(true);
    }
}
