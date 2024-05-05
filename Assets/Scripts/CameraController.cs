using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Transform target;

    [Header("Settings")]
    [SerializeField] private float offset;

    private void LateUpdate()
    {
        Vector3 targetPostion = new Vector3(target.position.x, transform.position.y, target.position.z + offset);
        transform.position = targetPostion;
        
    }
}
