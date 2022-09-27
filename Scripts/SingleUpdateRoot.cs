using System;
using System.Collections.Generic;
using UnityEngine;

public class SingleUpdateRoot : MonoBehaviour
{
    private void Awake()
    {
        var other = FindObjectsOfType<SingleUpdateRoot>();
        if (other.Length > 1)
        {
            Debug.LogError($"There are {other.Length} SingleUpdateRoots in scene!");
            Destroy(gameObject);
            return;
        }
    }

    private void Update()
    {
        SingleUpdateBehaviour.onUpdate?.Invoke();
    }

    private void FixedUpdate()
    {
        SingleUpdateBehaviour.onFixedUpdate?.Invoke();
    }

    private void LateUpdate()
    {
        SingleUpdateBehaviour.onLateUpdate?.Invoke();
    }
}