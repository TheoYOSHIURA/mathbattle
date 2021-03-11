using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject playerCharacter;

    private float moveSpeed = 0.005F;


    // Update is called once per frame
    private void Start()
    {
        playerCharacter = GameObject.Find("Hero");
    }

    void Update()
    {
        if (this.transform.position.x - playerCharacter.transform.position.x > 2 )
        {
            transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(playerCharacter.transform.position.x, playerCharacter.transform.position.y + 1.4F), moveSpeed);
        }
    }
}
