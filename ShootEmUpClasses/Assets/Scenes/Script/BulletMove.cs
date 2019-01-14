using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	void Update () {
        transform.Translate(Vector3.right * 4 * Time.deltaTime);
    }
}
