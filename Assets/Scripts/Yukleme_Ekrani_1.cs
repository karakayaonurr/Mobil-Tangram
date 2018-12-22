using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yukleme_Ekrani_1 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public int YaziBoyutu;
    public Texture2D ArkaPlan;
    public Texture2D Normal;
    public float YuklemeBari = 0.2f;
    public float Hiz = 0.003f;

    void Update()
    {
        YaziBoyutu = Screen.width / 9;
        YuklemeBari += Hiz;
        if (YuklemeBari >= 1)
        {
            if (PlayerPrefs.GetString("Kullanici") == "var" && PlayerPrefs.GetString("KullaniciAdi") != "İsim")
            {
                SceneManager.LoadScene("3-Ana_Menu");
            }
            else
            {
                SceneManager.LoadScene("2-Giris_Ekrani");
            }
        }
    }

    void OnGUI()
    {
        Fonksiyonlar.YaziAlani(YaziBoyutu, YaziStili2, ArkaPlan, ArkaPlan, Color.white);
        GUIStyle Ortalama = new GUIStyle(GUI.skin.textField);
        Ortalama.alignment = TextAnchor.MiddleCenter;
        GUI.TextField(Fonksiyonlar.Pozisyon(0.5f, 0.95f, 0.5f, 0.2f), "Tangra-M", Ortalama);

        Fonksiyonlar.BosKutu(YaziStili, YaziBoyutu, Color.white);
        GUI.Box(Fonksiyonlar.Pozisyon(1, 0.1f, 1, 0.2f), "MOBİL\nTANGRAM");
        Fonksiyonlar.ArkaPlanliKutu(YaziStili, Normal, YaziBoyutu / 2, Color.black);
        GUI.Box(Fonksiyonlar.Pozisyon(YuklemeBari, -0.5f, YuklemeBari, 0.08f), "Yukleniyor...");
    }
}
