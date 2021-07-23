using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    [SerializeField] private Texture2D _icon;


    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 100), new GUIContent(_icon));
    }

}
