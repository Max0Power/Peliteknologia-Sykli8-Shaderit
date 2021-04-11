using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Lopettaa ohjelman painamalla Esc -painiketta
/// </summary>
public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
