using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody))]
public class PlayerInput : MonoBehaviour
{
    private bool isFalling = false;
    private Rigidbody rb;
    [Range(0,5)] public float Speed = 5;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (!isFalling)
        {
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);

            }
            else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.constraints = RigidbodyConstraints.FreezePositionZ;
                isFalling = true;
            }
        }
    }
}
