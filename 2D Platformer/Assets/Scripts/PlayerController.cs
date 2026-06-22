using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float jumpForce;

    private Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void OnMoveInput (InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
    }

    public void OnJumpInput (InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
    }
}
