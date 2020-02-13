using UnityEngine;

public class shootBullet : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(0, 100, 1000);
            rb.useGravity = true;
            Debug.Log("mouse clicked");
        }
    }
}
