using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject spawningGameObject;
    private float timer = 1;
    public GameObject upper;
    public GameObject lower;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Print());
    }

    // Update is called once per frame
/*    void Update()
    {
        if (timer > 2)
        {
            timer -= 1.8f;

        } else
        {
            timer += Time.deltaTime;
        }
        
    }*/

    IEnumerator Print()
    {
        while (true)
        {
            var obj = Instantiate(spawningGameObject, new Vector3(15.63F, Random.Range(-2.7F, 2.45f), 0), transform.rotation);
            Destroy(obj, 5f);
            yield return new WaitForSeconds(timer);
        }
    }

}
