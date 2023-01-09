using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    bool isFire;
    Vector3 direction;
    public float speed = 10f;

    public void Fire(Vector3 dir)
    {
        direction = dir;
        isFire = true;
        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        if (isFire)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var controller = collision.gameObject.GetComponent<SimpleCharacterController>();
        if(controller != null)
        {
            controller.hp -= 1;
        }
        Destroy(gameObject);
    }
}
