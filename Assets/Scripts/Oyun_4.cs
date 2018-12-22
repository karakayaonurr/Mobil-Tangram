using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyun_4 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public int YaziBoyutu;
    public Texture2D ArkaPlan;
    public Texture2D Normal;
    public Texture2D Uzerinde;
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

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Normal, Uzerinde, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, 0.25f, 0.5f, 0.08f), "KOLAY"))
        {
            SceneManager.LoadScene("411-Oyun");
        }
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, 0, 0.5f, 0.08f), "ZOR"))
        {
            SceneManager.LoadScene("421-Oyun");
        }
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.5f, 0.5f, 0.08f), "GERİ"))
        {
            SceneManager.LoadScene("3-Ana_Menu"); ;
        }
    }
}
