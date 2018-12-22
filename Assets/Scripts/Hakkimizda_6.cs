using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hakkimizda_6 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public Font YaziStili3;
    public int YaziBoyutu;
    public Texture2D ArkaPlan;
    public Texture2D ArkaPlan2;
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

        GUIStyle Ortala = new GUIStyle(GUI.skin.textArea);
        Ortala.alignment = TextAnchor.MiddleCenter;
        Fonksiyonlar.YaziAlani2(YaziBoyutu / 3, YaziStili3, ArkaPlan2, ArkaPlan2, Color.black);
        GUI.TextArea(Fonksiyonlar.Pozisyon(0.75f, 0.4f, 0.75f, 0.5f), "Kocaeli Üniversitesi\nBilgisayar Mühendisliği\nbitirme projesidir.\n\nHazirlayan:\nOnur Karakaya\nCan Özer\n\n© 2018", Ortala);

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Normal, Uzerinde, Color.white);
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.65f, 0.5f, 0.08f), "GERİ"))
        {
            SceneManager.LoadScene("3-Ana_Menu");
        }
    }
}
