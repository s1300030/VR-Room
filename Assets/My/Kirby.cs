using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kirby : MonoBehaviour
{
    public void SwitchAppear(){

        gameObject.SetActive(!gameObject.activeSelf);
    }

    
}
