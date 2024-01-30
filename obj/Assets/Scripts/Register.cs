using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    //Declaring Inputfields
    public InputField FullnameEntered;
    public InputField AgeEntered;
    public InputField CellNumberEntered;

    //Declaring Text Displays
    public Text RegisterError;

    public void RegisterUI()
    {
        if (FullnameEntered.text != "" && AgeEntered.text != "" && CellNumberEntered.text != "")
        {
            PlayerPrefs.SetString("Fullname", FullnameEntered.text);
            PlayerPrefs.SetString("Age", AgeEntered.text);
            PlayerPrefs.SetString("CellNo", CellNumberEntered.text);

            FullnameEntered.text = " ";
            AgeEntered.text = " ";
            CellNumberEntered.text = " ";

            SceneManager.LoadScene("ObjectInteraction");

        }
        else
        {
            RegisterError.text = "Please enter information!";
        }
    }

}
