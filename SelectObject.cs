using UnityEngine;

public class SelectObject : MonoBehaviour
{
    void Update()
    {
        // Call every frame
        MouseInput();
    }

    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButton(0))
        {
            // Raycast from camera to mouse position
            Vector2 raycastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastPos, Vector2.zero);

            // If a collider is hit
            if (hit.collider != null)
            {
                // Log the name of the hit object
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
