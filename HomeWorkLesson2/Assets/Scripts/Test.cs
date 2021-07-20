using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string _text;
    private void OnGui()
    {
        GUI.Box(new Rect(20, 20, 300, 500), "Box");
        if (GUI.Button(new Rect(30, 30, 100, 200), "Button 1")) 
            _text = "Click Button 1";


        GUI.Box(new Rect(50, 60, 300, 500), "Box");
        if (GUI.Button(new Rect(30, 30, 100, 200), "Button 2"))
            _text = "Click Button 2";


        GUI.Label(new Rect(200, 30, 200, 300), _text);
    }
}
