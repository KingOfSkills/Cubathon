using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
        if(UnityEditor.EditorApplication.isPlaying == true)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
