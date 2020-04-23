using UnityEngine;

public class ammo : MonoBehaviour
{
    Collider col;
    public GameObject goCamera;
    public GameObject goBullet;
    public Rigidbody rbBullet;

    void Start()
    {
        col = GetComponent<Collider>();
        goCamera = GameObject.Find("Main Camera");
        goBullet = GameObject.Find("bullet");
        rbBullet = goBullet.GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider player)
    {
        SetParent(goCamera);
        goBullet.GetComponent<shootBullet>().reset();
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SetParent(goCamera);
            goBullet.GetComponent<shootBullet>().reset();
        }
    }


    public void SetParent(GameObject newParent)
    {
        Debug.Log("entered");
        goBullet.transform.parent = newParent.transform;
        Debug.Log("parent = " + goBullet.transform.parent.name);
    }

}
