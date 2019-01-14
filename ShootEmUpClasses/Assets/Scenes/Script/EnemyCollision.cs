using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Instantiate(enemy, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
