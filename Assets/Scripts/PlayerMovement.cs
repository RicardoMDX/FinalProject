using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    Rigidbody m_Rigidbody;
    private PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 tempVector = new Vector3(h, 0, v);
        tempVector = tempVector.normalized * playerManager.f_Speed * Time.deltaTime;
        m_Rigidbody.MovePosition(transform.position + tempVector);

        //Rotation
        Vector3 v3_MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        v3_MousePosition.y = 3.5f;

        transform.LookAt(v3_MousePosition);
    }
}
