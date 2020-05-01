using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject crosshairs;
    public GameObject projectile;
    public GameObject p;
    public float projectileSpeed = 20.0f;
    private Vector3 target;
    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if(Input.GetMouseButton(0) && timeBtwShots <= 0)
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
        p = Instantiate(projectile) as GameObject;
        p.transform.position = transform.position;
        p.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        p.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
        //Destroy(p, 1);
    }
}
