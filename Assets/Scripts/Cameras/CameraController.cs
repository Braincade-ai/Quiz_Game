using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothTime = 0.2f;
    [SerializeField] private float yOffset = 2.0f;

    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        if (player == null)
            return;

        // Set the target position with the player's x-position and a fixed y-position
        Vector3 targetPosition = new Vector3(player.position.x, 0f + yOffset, transform.position.z);

        // Smoothly move the camera towards the target position using SmoothDamp
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }


}
