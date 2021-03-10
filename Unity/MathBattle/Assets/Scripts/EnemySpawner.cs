using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    
    private int temps = 0;
    private int delay = 600;

    // Update is called once per frame
    void Update()
    {
        temps++;

        if(temps - delay == 0)
        {
            temps -= delay;
            delay--;
            Instantiate(enemy1);
        }
    }
}
