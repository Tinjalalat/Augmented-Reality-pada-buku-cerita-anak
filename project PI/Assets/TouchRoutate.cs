using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    [Header("Rotation speed multiplier")]
    public float rotationSpeed = 5f;

    void Update()
    {
#if UNITY_EDITOR
        // Untuk tes di Editor pakai mouse
        if (Input.GetMouseButton(0))
        {
            float rotateX = -Input.GetAxis("Mouse Y") * rotationSpeed;
            float rotateY = Input.GetAxis("Mouse X") * rotationSpeed;

            transform.Rotate(rotateX, rotateY, 0, Space.World);
            Debug.Log("Mouse rotasi di Editor!");
        }
#else
        // Untuk HP (touch input)
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 delta = touch.deltaPosition;

                float rotateX = -delta.y * rotationSpeed * Time.deltaTime;
                float rotateY = delta.x * rotationSpeed * Time.deltaTime;

                transform.Rotate(rotateX, rotateY, 0, Space.World);
                Debug.Log("Sentuhan terdeteksi di HP!");
            }
        }
#endif
    }
}
