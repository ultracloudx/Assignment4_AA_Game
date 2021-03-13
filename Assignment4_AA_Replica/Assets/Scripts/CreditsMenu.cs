using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game and going to End Scene");
        Application.Quit();
    }
}
