using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorScript : MonoBehaviour
{
    public Renderer Bones;
    public GameObject Bone;
    public Text Credentials;
    public Text DateAndTime;
    public Text Age;
    public Text CellNumber;
    public Text Error;
    public GameObject partic;
    public AudioClip sound;
    public AudioClip sound2;


    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
        GetComponent<AudioSource>().clip = sound2;

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Needle")
        {
            Bones.material.color = Color.green;
            partic.SetActive(true);

            GetComponent<AudioSource>().clip = sound;
            GetComponent<AudioSource>().Play();

            PlayerPrefs.SetString("time_stamp", System.DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));

            Credentials.text = " " + PlayerPrefs.GetString("Fullname");
            Age.text = " " + PlayerPrefs.GetString("Age");
            CellNumber.text = " " + PlayerPrefs.GetString("CellNo");

            DateAndTime.text = " " + PlayerPrefs.GetString("time_stamp");

            Error.text = " ";
        }

        else  if (collision.collider.name == "Plunger")
        {
            Bones.material.color = Color.red;

            GetComponent<AudioSource>().clip = sound2;
            GetComponent<AudioSource>().Play();

            Error.text = "Needle Inserted Too Deep!!!";
        }
    }

    
}
