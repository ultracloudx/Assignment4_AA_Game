using UnityEngine.UI;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    public Toggle toggle;
    //public GameObject AudioManager;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMusic()
    {
        if (toggle.isOn)
        {
            FindObjectOfType<AudioManager>().Play("BGM");
        }
        else
        {
            FindObjectOfType<AudioManager>().Pause("BGM");
        }
    }
}
