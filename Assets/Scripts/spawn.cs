using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float MaxTime=1f;
    float Timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > MaxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3 (0, Random.Range(-height,height),0);
            Destroy(newpipe, 10);

            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}
