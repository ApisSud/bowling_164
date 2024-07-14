using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;
    [SerializeField]
    private float increment;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ShootBowl();
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            MoveLeft();
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            MoveRight(); 
    }
    public void ShootBowl()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }
    public void MoveLeft()
    {
        transform.position += new Vector3(-increment, 0f, 0f);
    }
    public void MoveRight()
    {
        transform.position += new Vector3(increment, 0f, 0f);
    }
}
