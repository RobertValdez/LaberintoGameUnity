using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveName : MonoBehaviour
{
    Text _textName;
    void Awake() {
        _textName = GetComponent<Text>();
    }
    void Update()
    {
         GameManager.sharedInstance_gm.nameUser = _textName.text;
    }
}
