using UnityEngine;
using System.Collections;
public class UIresolutionForce : MonoBehaviour
{
    public int ScreenWidth;
    public int ScreenHeight;

    void Awake()
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer ||
        Application.platform == RuntimePlatform.OSXPlayer ||
        Application.platform == RuntimePlatform.LinuxPlayer)
        {
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        }
    }
}