using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject closestGameObject;
    GameObject[] allObjects;
    public float moveSpeed = 10;

    void Start()
    {
        allObjects = (GameObject[])FindObjectsOfType(typeof(GameObject));

        foreach (GameObject gameObject in allObjects)
        {
            if (closestGameObject is null)
            {
                closestGameObject = gameObject;
            }

            float xDiff = this.transform.position.x - gameObject.transform.position.x;
            float yDiff = this.transform.position.y - gameObject.transform.position.y;
            float posDiff = Math.Abs(xDiff) + Math.Abs(yDiff);

            float xDiffClosest = this.transform.position.x - closestGameObject.transform.position.x;
            float yDiffClosest = this.transform.position.y - closestGameObject.transform.position.y;
            float posDiffClosest = Math.Abs(xDiffClosest) + Math.Abs(yDiffClosest);

            if (posDiff < posDiffClosest)
            {
                closestGameObject = gameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(closestGameObject.transform.position.x, closestGameObject.transform.position.y), moveSpeed);
    }
}
