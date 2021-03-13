using UnityEngine.UI;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    public Toggle musicToggle;
    public GameObject AudioManager;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMusic()
    {
        if (musicToggle.isOn)
        {
            PlayerPrefs.SetInt("music", 1);
            //Set audio volume to 0.15
            Debug.Log("On");
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
            //Set audio volume to 0
            Debug.Log("Off");
        }
    }
}
