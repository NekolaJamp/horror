using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Transform player;
    public float speed = 4.0f;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("FPSController").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        Vector3 delta = player.transform.position - transform.position;
        delta.Normalize();
        transform.position = transform.position + delta * speed * Time.deltaTime;
    }
    private void OnColisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
            Destroy(gameObject);
    }
}