using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform Player;
    public Vector3 offset;
    private void Start()
    {
        offset = Player.position - transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Player.position - offset, Time.deltaTime * 5f);
        Quaternion rotation = Quaternion.LookRotation(Player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 3f);
    }


}
