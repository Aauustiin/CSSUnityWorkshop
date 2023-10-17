using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    float startTime, elapsedTime;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        if (elapsedTime > 3)
        {
            var pipe = Instantiate(pipePrefab);
            pipe.transform.position += new Vector3(0, Random.Range(-2.5f, 2.5f));
            startTime = Time.time;
        }
    }
}
