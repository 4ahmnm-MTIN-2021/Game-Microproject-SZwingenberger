using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
// AM  Keyword Klassenname  Elternkasse
public class Sceneloader : MonoBehaviour
{
    //the Global values and object references gets declared
    // Am  Datentyp variablenName wird rechten Wert zugewiesen
    public int numberPress = 0;
    public InputField nameInput;
    public PlayerName playerName;
    public GameObject buttonPressText;

    //gets called in the onclick function of the Button
    // Am returntype Methodenaufruf mit leerer Parameterliste
    public void addButtenPress()
    {
        numberPress++; //add 1 to the counting value
        buttonPressText.GetComponent<Text>().text = numberPress.ToString(); //Display the ammount in textfield
        // if statement Variable Vergleichsoperator und Wert 5
        if (numberPress == 5) //check if button is pressed 5 times
        {
            LoadNextScene("SceneAdd");
        }
    }

    //switches scene based on scene names
    // Am  return type Methodenaufruf  
    public void LoadNextScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void UpdatePlayerName() //safes the playername to scriptable game object
    {
        playerName.runtimevalue = nameInput.text;
    }

}
