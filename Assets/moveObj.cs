using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour
{
    public float speed;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform);
        transform.Translate(new Vector3(0f, 0f, speed));
    }
}
