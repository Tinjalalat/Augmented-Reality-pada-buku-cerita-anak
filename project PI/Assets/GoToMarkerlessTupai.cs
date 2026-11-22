using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMarkerlessTupai : MonoBehaviour
{
    // Nama scene AR yang dituju
    public string arSceneName = "MarkerlessTupai";

    // Fungsi dipanggil saat tombol diklik
    public void GoToARScene()
    {
        SceneManager.LoadScene(arSceneName);
    }
}