using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    Rigidbody m_Rigidbody;
    float h, v, moveLimiter=0.7f;
    private PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //Movement

        if (h != 0 && v != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            h *= moveLimiter;
            v *= moveLimiter;
        }

        m_Rigidbody.velocity = new Vector3(h * playerManager.f_Speed, 0, v * playerManager.f_Speed);

        //Rotation
        Vector3 v3_MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        v3_MousePosition.y = 3.5f;

        transform.LookAt(v3_MousePosition);
    }
}
