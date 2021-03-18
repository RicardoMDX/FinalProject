using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        playerManager =GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * playerManager.f_ShotSpeed * Time.deltaTime);
        Destroy(this.gameObject, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SendMessage("Hit", playerManager.i_Damage);
        }
    }
}
