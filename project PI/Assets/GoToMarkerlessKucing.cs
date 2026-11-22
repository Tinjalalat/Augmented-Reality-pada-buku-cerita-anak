using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerlessKucing : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "MarkerlessKucing";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}