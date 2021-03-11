using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    
    private int temps = 0;
    public int delay = 1000;
    public int minDelay = 100;

    System.Random rnd = new System.Random();
    private int random;

    void Update()
    {
        temps++;

        if(temps - delay == 0)
        {
            temps -= delay;
            if (delay > minDelay)
            {
                delay--;
            }

            random = rnd.Next(-7, 7);
            Instantiate(enemy1, new Vector2(this.transform.position.x, this.transform.position.y + random), this.transform.rotation);
        }
    }
}
