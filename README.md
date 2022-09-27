# Single-Update
Provides classes for optimization of default MonoBehaviour updates

## How to use
Implement SingleUpdateBehaviour to your component class. Override OnUpdate(), OnFixedUpdate() or OnLateUpdate() methods instead of default Update(), FixedUpdate() or OnLateUpdate()

Don't forget to add a SingleUpdateRoot object into the scene where SingleUpdateBehaviour's used
