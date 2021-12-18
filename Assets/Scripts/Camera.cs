using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform followTarget;

    private Vector3 initialDistance;

    private void Awake()
    {
        initialDistance = transform.position - followTarget.position;
    }

    private void Update()
    {
        transform.position = followTarget.position + initialDistance;
    }
}
