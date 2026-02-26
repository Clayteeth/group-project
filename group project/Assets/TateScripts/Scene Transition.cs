using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Tate");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}