using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToARSceneButton : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "beruang scene";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}
