using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public IState jumpState = new JumpState();
    public GameObject player;
    public int gravity;

    // Start is called before the first frame update
    void Start()
    {
        // do something
    }

    // Update is called once per frame
    void Update()
    {
        // do something
    }
}
