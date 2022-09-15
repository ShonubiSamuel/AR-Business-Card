using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    public float rot;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, rot, 0f) * Time.deltaTime);
    }
}
