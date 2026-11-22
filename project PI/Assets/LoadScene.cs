using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public string mainSceneName = "LayarUtama";  // Nama scene utama kamu

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(mainSceneName);
    }
}
