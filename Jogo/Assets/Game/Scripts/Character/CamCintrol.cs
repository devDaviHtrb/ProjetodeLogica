using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCintrol : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;
    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y+3, transform.position.z);
    }
}

