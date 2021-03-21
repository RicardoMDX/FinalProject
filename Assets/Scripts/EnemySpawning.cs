using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameManager scr_GameManager;
    public GameObject go_Zombie;
    public GameObject[] go_EnemySpawns;

    // Start is called before the first frame update
    void Start()
    {

    }

    void SpawnWave()
    {
        while (scr_GameManager.i_EnemiesAlive < scr_GameManager.i_Enemies)
        {
            Debug.Log("Spawn Enemy");
            Debug.Log("Spawning " + (scr_GameManager.i_EnemiesAlive + 1) + " of " + scr_GameManager.i_Enemies);
            Instantiate(go_Zombie, go_EnemySpawns[Random.Range(1, 12)].transform);
            scr_GameManager.i_EnemiesAlive++;
        }
    }
}
