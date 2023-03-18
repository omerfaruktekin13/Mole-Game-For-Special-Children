using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class orta : MonoBehaviour
{
    public GameObject gectinpanel, tekrarlapanel, exitpanel, yandinpanel;
    float kes;
    float zamanal1;
    float zamanal2;
    public float gercekzaman;
    public Text timee;
    public Text skor;
    public AudioSource[] auu;
    int score;
    List<int> list = new List<int>();
    public Button vur1;
    public Button vur2;
    public Sprite davulresim, zilresim, normal, cut;
    public SpriteRenderer kost1,kost2;
    int s1,s2,s3,s4,s5,s6,s7,s8,s9,s10;
    
    void Start()
    {
        gectinpanel.SetActive(false); tekrarlapanel.SetActive(false); exitpanel.SetActive(false);yandinpanel.SetActive(false);
        s1 =Random.Range(0,2);s2=Random.Range(2,4);s3=Random.Range(4,6); s4 = Random.Range(6, 8); s5 = Random.Range(8, 10); s6 = Random.Range(10, 12); s7 = Random.Range(12, 14); s8 = Random.Range(14, 16);
        s9 = Random.Range(16, 18); s10 = Random.Range(18, 20);
        gercekzaman = 0f;
        vur1.onClick.AddListener(taskonclicksol);
        vur2.onClick.AddListener(taskonclicksag);
        score = 0;

        auu[s1].PlayDelayed(2.0f); auu[s2].PlayDelayed(5.0f); auu[s3].PlayDelayed(8.0f); auu[s4].PlayDelayed(11.0f); auu[s5].PlayDelayed(14.0f); auu[s6].PlayDelayed(17.0f); auu[s7].PlayDelayed(20.0f);
        auu[s8].PlayDelayed(23.0f); auu[s9].PlayDelayed(26.0f); auu[s10].PlayDelayed(29.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        gercekzaman += Time.deltaTime;
        
        timee.text = gercekzaman.ToString("F0");
        skor.text = "Skor " + score.ToString();
        if (gercekzaman >= kes + 2)
        {
            kost1.sprite = normal;
            kost2.sprite = normal;
        }
        if (gercekzaman > 32)
        {
            if (score < 3) { yandinpanel.SetActive(true); }
            else if (score >= 3 && score < 7) { tekrarlapanel.SetActive(true); }
            else if (score >= 7) { gectinpanel.SetActive(true); }
        }
    }
    public void taskonclicksol()
    {
        zamanal1 = Time.time;
        if (zamanal1 >= 2 && zamanal1 <=5&&s1==0) {score += 1;}
        else if (zamanal1 >= 5 && zamanal1 <= 8 && s2 == 2) { score += 1; }
        else if (zamanal1 >= 8 && zamanal1 <= 11 && s3 == 4) { score += 1; }
        else if (zamanal1 >= 11 && zamanal1 <= 14 && s4 == 6) { score += 1; }
        else if (zamanal1 >= 14 && zamanal1 <= 17 && s5 == 8) { score += 1; }
        else if (zamanal1 >= 17 && zamanal1 <= 20 && s6 == 10) { score += 1; }
        else if (zamanal1 >= 20 && zamanal1 <= 23 && s7 == 12) { score += 1; }
        else if (zamanal1 >= 23 && zamanal1 <= 26 && s8 == 14) { score += 1; }
        else if (zamanal1 >= 26 && zamanal1 <= 29 && s9 == 16) { score += 1; }
        else if (zamanal1 >= 29 && zamanal1 <= 32 && s10 == 18) { score += 1; }
    }
    public void taskonclicksag()
    {
        zamanal2 = Time.time;
        if (zamanal2 >= 2 && zamanal2 <= 5 && s1 == 1) { score += 1; }
        else if (zamanal2 >= 5 && zamanal2 <= 8 && s2 == 3) { score += 1; }
        else if (zamanal2 >= 8 && zamanal2 <= 11 && s3 == 5) { score += 1; }
        else if (zamanal2 >= 11 && zamanal2 <= 14 && s4 == 7) { score += 1; }
        else if (zamanal2 >= 14 && zamanal2 <= 17 && s5 == 9) { score += 1; }
        else if (zamanal2 >= 17 && zamanal2 <= 20 && s6 == 11) { score += 1; }
        else if (zamanal2 >= 20 && zamanal2 <= 23 && s7 == 13) { score += 1; }
        else if (zamanal2 >= 23 && zamanal2 <= 26 && s8 == 15) { score += 1; }
        else if (zamanal2 >= 26 && zamanal2 <= 29 && s9 == 17) { score += 1; }
        else if (zamanal2 >= 29 && zamanal2 <= 32 && s10 == 19) { score += 1; }
    }
    public void soltiklama()
    {
        kost1.sprite = cut;
        kes = gercekzaman;
    }
    public void sagtiklama()
    {
        kost2.sprite = cut;
        kes = gercekzaman;
    }
    public void anamenu()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void tekrarla_o1()
    {
        SceneManager.LoadScene("o1");
    }
    public void tekrarla_o2()
    {
        SceneManager.LoadScene("o2");
    }
    public void tekrarla_o3()
    {
        SceneManager.LoadScene("o3");
    }
    public void yenibolum_o1()
    {
        SceneManager.LoadScene("z1");
    }
    public void yenibolum_o2()
    {
        SceneManager.LoadScene("z2");
    }
    public void yenibolum_o3()
    {
        SceneManager.LoadScene("z3");
    }
    public void eskibolum_o1()
    {
        SceneManager.LoadScene("k1");
    }
    public void eskibolum_o2()
    {
        SceneManager.LoadScene("k2");
    }
    public void eskibolum_o3()
    {
        SceneManager.LoadScene("k3");
    }
    public void cikis()
    {
        exitpanel.SetActive(true);
    }
}
