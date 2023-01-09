using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public GameObject bulletPrefab;
    float delay = 1f;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay)
        {
            var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(transform.forward);
            timer = 0;
        }
    }
}
