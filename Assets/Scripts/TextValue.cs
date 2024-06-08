using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextValue : MonoBehaviour
{
    public Text helloName;

    public InputField name;

    public InputField name1;

    // Update is called once per frame
    void Update()
    {
        string UserName = name.text;
        string UserName1 = name1.text;

        helloName.text = "first name : " + UserName;
        helloName.text = "last name : " + UserName1;
    }
}
