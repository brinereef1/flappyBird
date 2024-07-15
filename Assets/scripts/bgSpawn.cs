using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bgSpawn : MonoBehaviour
{
    public GameObject bg;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= 3;
            var obj = Instantiate(bg, transform.position, transform.rotation);
            Destroy(obj, 5f);
        } else
        {
            timer += Time.deltaTime;
        }

    }
}
