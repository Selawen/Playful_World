using UnityEngine;

public class shootBullet : MonoBehaviour
{
    public CapsuleCollider col;
    public Rigidbody rb;
    public MeshRenderer mesh;
    public bool shot;
    public float damage = 10f;
    public float range = 1000f;

    void Start()
    {
        col = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        shot = false;
    }


    void Update()
    {
        if (shot == false && Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        else if (shot == true)
        {
            transform.parent = null;
        }
    }

    void shoot()
    {
        col.enabled = true;
        mesh.enabled = true;
        rb.AddRelativeForce(0, range, -100);
        rb.useGravity = true;
        Debug.Log("mouse clicked");
        shot = true;
    }

    public void reset()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        rb.velocity = new Vector3(0, 0, 0);
        Debug.Log("position = " + transform.position);

        rb.angularVelocity = new Vector3(0, 0, 0);
        transform.localRotation = transform.parent.rotation;
        transform.localRotation = Quaternion.Euler(90f, 0f, 0f); 

        col.enabled = false;
        mesh.enabled = false;
        rb.useGravity = false;
        shot = false;
    }
}
