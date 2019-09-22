using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
public class ClickOnWeb : MonoBehaviour
{
    MeshRenderer mesh;

    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        if(gameObject.name == "LinkedIn")
        {
            Application.OpenURL("https://www.linkedin.com/in/sa%C5%A1a-stankovi%C4%87-0b789192/");
        }
        else if(gameObject.name == "Website")
        {
            Application.OpenURL("https://remex.rs/");
        }
        else if(gameObject.name == "Email")
        {
            Application.OpenURL("mailto:sasa.stankovic@remex.rs");
        }

  
    }

    

    
}
