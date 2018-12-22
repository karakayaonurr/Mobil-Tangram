using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyun_411 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public int YaziBoyutu;
    public Texture2D ArkaPlan;
    public Texture2D Normal;
    public Texture2D Uzerinde;
    public Texture2D Figur1;
    public Texture2D Figur2;
    public Texture2D Figur3;
    public string KullaniciAdi;

    void Update()
    {
        YaziBoyutu = Screen.width / 9;
        KullaniciAdi = PlayerPrefs.GetString("KullaniciAdi");
    }

    void OnGUI()
    {
        Fonksiyonlar.YaziAlani(YaziBoyutu, YaziStili2, ArkaPlan, ArkaPlan, Color.black);
        GUIStyle Ortalama = new GUIStyle(GUI.skin.textField);
        Ortalama.alignment = TextAnchor.MiddleCenter;
        GUI.TextField(Fonksiyonlar.Pozisyon(0.5f, 0.95f, 0.5f, 0.2f), KullaniciAdi, Ortalama);

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur1, Figur1, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.9f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S01");
        }
        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur2, Figur2, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.25f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S02");
        }
        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur3, Figur3, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(-0.4f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S03");
        }

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Normal, Uzerinde, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.47f, 0.5f, 0.08f), "İLERİ"))
        {
            SceneManager.LoadScene("412-Oyun");
        }
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.65f, 0.5f, 0.08f), "GERİ"))
        {
            SceneManager.LoadScene("4-Oyun");
        }
    }
}
