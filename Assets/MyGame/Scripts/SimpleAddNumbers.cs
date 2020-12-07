using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//AM   keyword  Klassenname     Elternklasse
public class SimpleAddNumbers : MonoBehaviour
{ // AM    Variablen typ Variablen Name
    public InputField input1;
    public InputField input2;
    // Am  Datentyp Variablenname
    public int result;
    public Button resultButton;
    // Am  return type Methodenname leere Parameterliste
    public void CalculateResult()
    {
        result = int.Parse(input1.text) + int.Parse(input2.text); //Konvertieren von strings in Ints und Hinzufügen des Betrags, der in die Eingabefelder eingegeben wurde
        GameObject resulttext = resultButton.gameObject.transform.GetChild(0).gameObject; //liefert das Kind des buttonobject (Textfield)
        resulttext.GetComponent<Text>().text = result.ToString(); //Zeigt das Ergebnis im Textfield an 
        resultButton.interactable = false; //deaktiviert den button nach dem onclick
    }
}

