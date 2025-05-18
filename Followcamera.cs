using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    [SerializeField] GameObject thingtofollow;
    void LateUpdate()
    {
        transform.position = thingtofollow.transform.position + new Vector3 (+8f,0,-8.46f);
    }
}
