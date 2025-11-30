using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        transform.Rotate(transform.up, 1 * speed);
    }
}
