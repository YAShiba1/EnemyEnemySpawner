using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }
}
