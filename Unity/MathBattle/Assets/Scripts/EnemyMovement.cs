using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject playerCharacter;

    private int moveSpeed = 10;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, playerCharacter.transform.position, moveSpeed);
    }
}
