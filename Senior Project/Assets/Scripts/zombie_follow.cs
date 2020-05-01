using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_follow : MonoBehaviour
{
    public float speed;

    public Transform target;
    public float chaseRange;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject Projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget < chaseRange)
        {
            Vector3 targetDir = target.position - transform.position;
            transform.Translate(targetDir.normalized * Time.deltaTime * speed);
        }
    }
}
