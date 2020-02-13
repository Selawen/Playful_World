using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float sideSpeed = 10.0f;
    public float horizontalLook = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Now move!");
    }

    // Update is called once per frame
    void Update()
    {
        //movement over plane
        float forward = Input.GetAxis("Vertical") * speed;
        float sideways = Input.GetAxis("Horizontal") * sideSpeed;

        forward *= Time.deltaTime;
        sideways *= Time.deltaTime;

        transform.Translate(0, 0, forward);
        transform.Translate(sideways, 0, 0);

        //looking around with mouse
        float h = Input.GetAxis("Mouse X") * horizontalLook;

        transform.Rotate(0, h, 0);
    }
}
