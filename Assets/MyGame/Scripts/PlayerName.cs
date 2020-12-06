using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu] 
//AM   Keyword Klassenname Elternklasse    
public class PlayerName : ScriptableObject, ISerializationCallbackReceiver
{
    // AM  variablentyp variablenname
    public string runtimevalue; //value changes while game is played
    public string initialvalue;
    public void OnBeforeSerialize()
    {

    }
    public void OnAfterDeserialize() //reset value when the game ends
    {
        runtimevalue = initialvalue;
    }
}
