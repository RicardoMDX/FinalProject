using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float f_Speed, f_ROF, f_ShotSpeed;
    public int i_Health, i_Money, i_Damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hit(int i_Hit)
    {
        i_Health -= i_Hit;
    }
}
