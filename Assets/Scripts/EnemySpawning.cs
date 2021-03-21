using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject go_Zombie;
    public GameObject[] go_EnemySpawns;

    private float f_Timer=0.5f, f_LastSpawn;

    GameManager scr_GameManager;

    // Start is called before the first frame update
    void Start()
    {
        scr_GameManager = GetComponent<GameManager>();
    }
    
    void SpawnWave()
    {
        while ((scr_GameManager.i_EnemiesAlive < scr_GameManager.i_Enemies))
        {
            if (Time.time >= f_LastSpawn + f_Timer)
            {
                Debug.Log("Spawning " + (scr_GameManager.i_EnemiesAlive + 1) + " of " + scr_GameManager.i_Enemies);
                Instantiate(go_Zombie, go_EnemySpawns[Random.Range(1, 12)].transform);
                scr_GameManager.i_EnemiesAlive++;
                f_LastSpawn = Time.time;
            }
        }
    }
}
