using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;

    void update()
    {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
