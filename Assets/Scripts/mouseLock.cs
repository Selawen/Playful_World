using UnityEngine;

public class mouseLock : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

}
