using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform Checkpoint;
    public Rigidbody rb;

    public int Deaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-5)
        {
            transform.position = Checkpoint.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Deaths++;
        }
        if (!Input.GetKey("w") && !Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            Checkpoint = other.transform;
        }
        if (other.gameObject.name == "mål")
        {
            SceneManager.LoadScene("Winn");
        }
    
    }
}
