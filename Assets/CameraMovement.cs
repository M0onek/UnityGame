using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rect rect;
    public Transform player;

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        if (player.position.x > rect.x && player.position.x < rect.x + rect.width) pos.x = player.position.x;
        if (player.position.y > rect.y && player.position.y < rect.y + rect.height) pos.y = player.position.y;
        transform.position = pos;
    }
}
