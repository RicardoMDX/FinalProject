using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int i_Health, i_Damage;
    public float f_Speed;
    private GameObject go_player;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        go_player = GameObject.FindGameObjectWithTag("Player");
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, go_player.transform.position, f_Speed);
        if (i_Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            collision.gameObject.SendMessage("Hit", i_Damage);
        }
    }
    public void Hit(int i_Damage)
    {
        i_Health -= i_Damage;
    }
}
