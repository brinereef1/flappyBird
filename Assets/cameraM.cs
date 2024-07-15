using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraM : MonoBehaviour
{
    public GameObject player;
    private Vector2 currentP;
    // Start is called before the first frame update
    void Start()
    {
        currentP = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = Vector2.MoveTowards(currentP, player.transform.position, 5 * Time.deltaTime);

        Debug.Log(newPos);
    }
}
