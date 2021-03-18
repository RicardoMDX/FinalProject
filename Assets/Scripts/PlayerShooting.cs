using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject go_Shot, go_ShotSpawn;
    private PlayerManager playerManager;
    private float f_LastShot, f_NextShot;
    private bool b_AbleToFire;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=f_NextShot)
        {
            b_AbleToFire = true;
        }
        if(Input.GetMouseButton(0) && b_AbleToFire)
        {
            Instantiate(go_Shot, go_ShotSpawn.transform);
            b_AbleToFire = false;
            f_LastShot = Time.time;
            f_NextShot = f_LastShot + (1/playerManager.f_ROF);
        }
    }
}
