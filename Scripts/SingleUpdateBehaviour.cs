using System;
using UnityEngine;

public abstract class SingleUpdateBehaviour : MonoBehaviour
{
    public static Action onUpdate;
    public static Action onFixedUpdate;
    public static Action onLateUpdate;

    protected virtual void OnObjectEnable() { }
    private void OnEnable()
    {
        AddToSingleUpdate();
        OnObjectEnable();
    }

    protected virtual void OnObjectDisable() { }
    private void OnDisable()
    {
        RemovedFromSingleUpdate();
        OnObjectDisable();
    }

    protected virtual void OnObjectDestroy() { }
    private void OnDestroy()
    {
        RemovedFromSingleUpdate();
        OnObjectDestroy();
    }

    private void AddToSingleUpdate()
    {
        onUpdate += OnTick;
        onFixedUpdate += OnFixedTick;
        onLateUpdate += OnLateTick;
    }

    private void RemovedFromSingleUpdate()
    {
        onUpdate -= OnTick;
        onFixedUpdate -= OnFixedTick;
        onLateUpdate -= OnLateTick;
    }

    protected virtual void OnTick() { }
    protected virtual void OnFixedTick() { }
    protected virtual void OnLateTick() { }
}

