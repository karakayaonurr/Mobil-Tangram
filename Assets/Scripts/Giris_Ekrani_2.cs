using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Giris_Ekrani_2 : MonoBehaviour
{

    public Font YaziStili;
    public Font YaziStili2;
    public Texture2D ArkaPlan;
    public int YaziBoyutu;
    public Texture2D Normal;
    public Texture2D Uzerinde;
    public string KullaniciAdi = "İsim";

    void Update()
    {
        YaziBoyutu = Screen.width / 7;
    }

    private void OnGUI()
    {
        Fonksiyonlar.YaziAlani(YaziBoyutu * 7 / 9, YaziStili2, ArkaPlan, ArkaPlan, Color.black);
        GUIStyle Ortalama = new GUIStyle(GUI.skin.textField);
        Ortalama.alignment = TextAnchor.MiddleCenter;
        GUI.TextField(Fonksiyonlar.Pozisyon(0.5f, 0.95f, 0.5f, 0.2f), "Tangra-M", Ortalama);

        Fonksiyonlar.BosKutu(YaziStili, YaziBoyutu / 2, Color.black);
        GUI.Box(Fonksiyonlar.Pozisyon(1, 0.3f, 1, 0.2f), "Kullanıcı adı:");

        Fonksiyonlar.YaziAlani(YaziBoyutu / 2, YaziStili, Normal, Uzerinde, Color.white);
        KullaniciAdi = GUI.TextField(Fonksiyonlar.Pozisyon(0.6f, 0.1f, 0.6f, 0.1f), KullaniciAdi);

        Fonksiyonlar.ButonAlani(YaziStili, YaziBoyutu / 2, Normal, Uzerinde, Color.white);
        KullaniciAdi.Trim();
        if (GUI.Button(Fonksiyonlar.Pozisyon(0.5f, -0.5f, 0.5f, 0.08f), "Devam Et"))
        {
            KullaniciAdi = KullaniciAdi.Trim();
            if (KullaniciAdi != "" && KullaniciAdi != "İsim")
            {
                PlayerPrefs.SetString("Kullanici", "var");
                PlayerPrefs.SetString("KullaniciAdi", KullaniciAdi);
                SceneManager.LoadScene("3-Ana_Menu");
            }
        }
    }
}
