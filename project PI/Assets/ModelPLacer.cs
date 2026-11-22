using UnityEngine;

public class PositionModelInFront : MonoBehaviour
{
    public GameObject targetModel;
    public float distance = 1.5f;

    void Start()
    {
        if (targetModel != null)
        {
            Camera cam = Camera.main;
            targetModel.transform.position = cam.transform.position + cam.transform.forward * distance;
            targetModel.transform.rotation = Quaternion.LookRotation(-cam.transform.forward); // supaya model menghadap kamera
        }
    }
}