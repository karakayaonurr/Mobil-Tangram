using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar : MonoBehaviour
{

    public static new Rect Pozisyon(float sol, float yukari, float genislik, float yukseklik)
    {
        return new Rect(Screen.width * 0.5f - Screen.width * sol * 0.5f, Screen.height * 0.5f - Screen.height * yukari * 0.5f, Screen.width * genislik, Screen.height * yukseklik);
    }

    public static void BosKutu(Font stil, int boyut, Color renk)
    {
        GUI.skin.box.font = stil;
        GUI.skin.box.fontSize = boyut;
        GUI.skin.box.normal.background = null;
        GUI.skin.box.normal.textColor = renk;
    }

    public static void ArkaPlanliKutu(Font stil, Texture2D arkaplan, int boyut, Color renk)
    {
        GUI.skin.box.font = stil;
        GUI.skin.box.fontSize = boyut;
        GUI.skin.box.normal.background = arkaplan;
        GUI.skin.box.normal.textColor = renk;
    }

    public static void YaziAlani(int boyut, Font stil, Texture2D normal, Texture2D uzerinde, Color renk)
    {
        GUI.skin.textField.fontSize = boyut;
        GUI.skin.textField.font = stil;
        GUI.skin.textField.normal.background = normal;
        GUI.skin.textField.hover.background = normal;
        GUI.skin.textField.active.background = uzerinde;
        GUI.skin.textField.focused.background = uzerinde;
        GUI.skin.textField.active.textColor = renk;
        GUI.skin.textField.hover.textColor = renk;
        GUI.skin.textField.focused.textColor = renk;
        GUI.skin.textField.normal.textColor = renk;
    }

    public static void YaziAlani2(int boyut, Font stil, Texture2D normal, Texture2D uzerinde, Color renk)
    {
        GUI.skin.textArea.fontSize = boyut;
        GUI.skin.textArea.font = stil;
        GUI.skin.textArea.normal.background = normal;
        GUI.skin.textArea.hover.background = normal;
        GUI.skin.textArea.active.background = uzerinde;
        GUI.skin.textArea.focused.background = uzerinde;
        GUI.skin.textArea.active.textColor = renk;
        GUI.skin.textArea.hover.textColor = renk;
        GUI.skin.textArea.focused.textColor = renk;
        GUI.skin.textArea.normal.textColor = renk;
    }

    public static void ButonAlani(Font stil, int boyut, Texture2D normal, Texture2D uzerinde, Color renk)
    {
        GUI.skin.button.font = stil;
        GUI.skin.button.fontSize = boyut;
        GUI.skin.button.normal.background = normal;
        GUI.skin.button.hover.background = uzerinde;
        GUI.skin.button.active.background = uzerinde;
        GUI.skin.button.normal.textColor = renk;
        GUI.skin.button.hover.textColor = renk;
        GUI.skin.button.active.textColor = Color.gray;
    }
}
