using UnityEngine;

[RequireComponent(typeof(Camera))]
public class adaptivecamera : MonoBehaviour
{
    [Tooltip("The base size of the camera relative to the initial width/height)")]
    public float baseOrthographicSize;

    [Tooltip("The initial width-to-height ratio the game was designed for)")]
    public float referenceAspect = 16f / 9f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        AdjustCamera();
    }

    void Update()
    {

        AdjustCamera();
    }

    void AdjustCamera()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = baseOrthographicSize * (referenceAspect / currentAspect);
    }
}
