using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
// AM  Keyword Klassenname  Elternkasse
public class Sceneloader : MonoBehaviour
{
    //Declare Global values and object references
    public int numberPress = 0;
    public InputField nameInput;
    public PlayerName playerName;
    public GameObject buttonPressText;

    //gets called in the onclick function of the Button
    public void addButtenPress()
    {
        numberPress++; //add 1 to the counting value
        buttonPressText.GetComponent<Text>().text = numberPress.ToString(); //Display the ammount in textfield
        if (numberPress == 5) //check if button is pressed 5 times
        {
            LoadNextScene("SceneAdd");
        }
    }

    //switches scene based on scene names
    public void LoadNextScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void UpdatePlayerName() //safe playername to scriptable game object
    {
        playerName.runtimevalue = nameInput.text;
    }

}