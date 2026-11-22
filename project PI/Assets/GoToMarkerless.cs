using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerless : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "scene markerless beruang";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}
