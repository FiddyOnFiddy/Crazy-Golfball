using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    //private float dir;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }


	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.position = player.transform.position + offset;
       // transform.RotateAround(player.transform.position, Vector3(0, player.transform.rotation.y, 0), Time.deltaTime * 45);
    }
}
