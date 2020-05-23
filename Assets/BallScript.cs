using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject BallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (this.BallPrefab != null)
            {
                GameObject ball = GameObject.Instantiate(this.BallPrefab);
                ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -25);
            }
        }
    }
}
