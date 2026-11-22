using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerKucing : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "kucing scene";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}