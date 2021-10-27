using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    [Range(0, 10)] float distance = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Transform playerTransform = player.GetComponent<Transform>();
       // Transform playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position - new Vector3(0, 0, -distance);
    }
}
