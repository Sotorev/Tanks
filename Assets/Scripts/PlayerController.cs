using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed = 45f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    [SerializeField] private GameObject gunReference;
    [SerializeField] private GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //add rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        //Add move with w, a,s,d
        if (Input.GetKey(KeyCode.W))
        {
            //add rigidbody force
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile(); ;
        }
    }

    //launch projectile
    private void LaunchProjectile()
    {
        //instantiate projectile
        Instantiate(projectilePrefab, gunReference.transform.position, gunReference.transform.rotation);
        //add force to projectile
    }
}
