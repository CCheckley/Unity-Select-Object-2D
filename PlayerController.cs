using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        MouseInput();
    }

    void MouseInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 raycastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastPos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
