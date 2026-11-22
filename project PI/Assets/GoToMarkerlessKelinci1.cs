using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerlessKelinci : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "MkrlessKelinci";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}