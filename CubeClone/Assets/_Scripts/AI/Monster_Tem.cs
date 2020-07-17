using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Tem : MonoBehaviour
{
    public float detectionDist = 10f;
    public float moveSpeed = 5f;
    public float rotSpeed = 20f;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < detectionDist)
        {
            transform.forward = Vector3.MoveTowards(transform.forward, (player.position - transform.position) + new Vector3(0, 1, 0), Time.deltaTime * rotSpeed);
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionDist);
    }
}
