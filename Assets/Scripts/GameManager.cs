using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text txt_Wave, txt_Money, txt_Enemies;
    public Canvas cnv_Upgrades;
    public int i_Wave = 1, i_Money = 0, i_Enemies=3, i_EnemiesAlive=0;

    private EnemySpawning scr_EnemySpawning;
    private float f_IntervalStarted, f_Timer = 10;
    private bool b_Interval = false;

    // Start is called before the first frame update
    void Start()
    {
        scr_EnemySpawning = GetComponent<EnemySpawning>();
        WaveStart();
    }

    // Update is called once per frame
    void Update()
    {
        txt_Money.text = ("Money: " + i_Money + "£");
        txt_Enemies.text = "Enemies: " + i_EnemiesAlive + "/" + i_Enemies;
        if (i_EnemiesAlive == 0 && !b_Interval)
        {
            WaveInterval();
        }
        if((Time.time>=f_IntervalStarted+f_Timer) && (b_Interval==true))
        {
            b_Interval = false;
            WaveEnd();
        }
    }

    void WaveStart()
    {
        txt_Wave.text = "Wave "+i_Wave;
        scr_EnemySpawning.SendMessage("SpawnWave");
        Debug.Log("Wave Start");
    }

    void WaveInterval()
    {
        cnv_Upgrades.gameObject.SetActive(true);
        b_Interval = true;
        f_IntervalStarted = Time.time;
        Debug.Log("Wave Interval");
    }

    void WaveEnd()
    {
        cnv_Upgrades.gameObject.SetActive(false);
        i_Wave++;
        i_Enemies += 3;
        Debug.Log("Wave End");
        WaveStart();
    }
}
