using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu] 
//AM   Keyword Klassenname Elternklasse    
public class PlayerName : ScriptableObject, ISerializationCallbackReceiver
{
    // AM  variablentyp variablenname
    public string runtimevalue; //value changes while the game is played
    public string initialvalue;
    public void OnBeforeSerialize()
    {

    }
    // Am  return type Methode       
    public void OnAfterDeserialize() //resets value when the game ends
    {
        runtimevalue = initialvalue;
    }
}
