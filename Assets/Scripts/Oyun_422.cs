using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyun_422 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public int YaziBoyutu;
    public Texture2D ArkaPlan;
    public Texture2D Normal;
    public Texture2D Uzerinde;
    public Texture2D Figur10;
    public Texture2D Figur11;
    public Texture2D Figur12;
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

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur10, Figur10, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.9f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S14");
        }
        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur11, Figur11, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.25f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S15");
        }
        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Figur12, Figur12, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(-0.4f, 0.4f, 0.25f, 0.25f), ""))
        {
            SceneManager.LoadScene("S16");
        }

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Normal, Uzerinde, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.65f, 0.5f, 0.08f), "GERİ"))
        {
            SceneManager.LoadScene("421-Oyun");
        }
    }
}
