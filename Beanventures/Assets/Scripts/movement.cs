using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    void update()
    {
            transform.position += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
