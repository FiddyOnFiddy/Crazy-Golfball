using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private float dir;

	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.position = player.transform.position;
        transform.LookAt(transform.position + player.GetComponent<Rigidbody>().velocity);
    }
}
