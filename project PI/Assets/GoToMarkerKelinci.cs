using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerKelinci : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "kelinci scene";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}