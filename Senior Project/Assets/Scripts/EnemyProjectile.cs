using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;
    //public GameObject target;
    public float projectileSpeed;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = player.transform.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (timeBtwShots <= 0 && gameObject.GetComponent<zombie_follow>().chaseRange >= difference.magnitude)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            throwProjectile(direction, rotationZ);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    void throwProjectile(Vector2 direction, float rotationZ)
    {
        GameObject p;
        p = Instantiate(projectile) as GameObject;
        p.transform.position = transform.position;
        p.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        p.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
        //Destroy(p, 1);
    }
}
