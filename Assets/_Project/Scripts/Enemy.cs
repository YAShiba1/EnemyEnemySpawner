using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void RotateAxisY(int angle)
    {
        transform.Rotate(0, angle, 0);
    }
}
