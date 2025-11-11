using UnityEngine;

[RequireComponent(typeof(Camera))]
public class AdaptiveCamera : MonoBehaviour
{
    [SerializeField] private float baseAspect = 16f / 9f;
    [SerializeField] private float baseSize = 5f;

    void Update()
    {
        Camera cam = GetComponent<Camera>();
        float currentAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = baseSize * (baseAspect / currentAspect);
    }
}
