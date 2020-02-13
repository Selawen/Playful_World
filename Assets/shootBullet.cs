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
        if (KeyCode == 'a') {
            rb.AddForce(0, 200, 0);
        }
    }
}
