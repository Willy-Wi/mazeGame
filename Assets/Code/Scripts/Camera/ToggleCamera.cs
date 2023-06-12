using UnityEngine;
using System.Collections;

public class ToggleCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject playerCam;

    [SerializeField]
    private GameObject topCam;

    public void toggleCam()
    {
        playerCam.SetActive(!playerCam.activeSelf);
        topCam.SetActive(!topCam.activeSelf);
    }
}
