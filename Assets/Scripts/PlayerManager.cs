using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float f_Speed, f_ROF, f_ShotSpeed;
    public int i_Health, i_Damage;

    private GameManager scr_GameManager;

    // Start is called before the first frame update
    void Start()
    {
        scr_GameManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hit(int i_Hit)
    {
        i_Health -= i_Hit;
    }

    public void UpgradeSpeed()
    {
        if (scr_GameManager.i_Money > 0)
        {
            f_Speed += 5;
            scr_GameManager.i_Money--;
        }
    }

    public void UpgradeShotSpeed()
    {
        if (scr_GameManager.i_Money > 0)
        {
            f_ShotSpeed += 10;
            scr_GameManager.i_Money--;
        }
    }

    public void UpgradeRateOfFire()
    {
        if (scr_GameManager.i_Money > 0)
        {
            f_ROF += 1;
            scr_GameManager.i_Money--;
        }
    }

    public void UpgradeDamage()
    {
        if (scr_GameManager.i_Money > 0)
        {
            i_Damage += 1;
            scr_GameManager.i_Money--;
        }
    }

    public void UpgradeHealth()
    {
        if (scr_GameManager.i_Money > 0)
        {
            i_Health += 1;
            scr_GameManager.i_Money--;
        }
    }
}
