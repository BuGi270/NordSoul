using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField] private Transform camera;
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(player.position.x,0,camera.position.z);
    }
}
