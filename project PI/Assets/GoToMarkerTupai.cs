using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerTupai : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "tupai scene";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}