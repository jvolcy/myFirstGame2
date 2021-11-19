using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeMonster : MonoBehaviour
{
    public GameObject objectToCreate;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToCreate, new Vector3(490f, 1f, 500f), new Quaternion());
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(400, 600);
        float z = Random.Range(400, 600);

        if (Time.frameCount % 50 == 0)
        {
            Instantiate(objectToCreate, new Vector3(x, 1f, z), new Quaternion());

        }


    }
}
