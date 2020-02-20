using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float sideSpeed = 10.0f;
    public float horizontalLook = 2.0f;
    public float verticalLook = 2.0f;
    public float vRotation;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Now move!");
        player = GameObject.Find("player");
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
        float v = Input.GetAxis("Mouse Y") * verticalLook;

        vRotation -= v;

        vRotation = Mathf.Clamp(vRotation, -45f, 45f);

        transform.localRotation = Quaternion.Euler(vRotation, 0f, 0f);
        player.transform.Rotate(0, h, 0);


        /*float mouseX = Input.GetAxis("Mouse X") * MouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensetivity * Time.deltaTime;
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(Xrotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);*/
    }
}
