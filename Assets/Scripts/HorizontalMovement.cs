using UnityEngine;

public class HorizontalMovement : MonoBehaviour {
    [SerializeField] private float speed = 5f;

    private void Update() {
        var axisRaw = Input.GetAxisRaw("Horizontal");
        if (axisRaw == 0) {
            return;
        }

        transform.position += new Vector3(axisRaw * speed * Time.deltaTime, 0f, 0f);
    }
}