using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : SonMonoBehaviour
{
    public static InputManager instance;

    [Header("Move Input")]
    protected InputSystem_Actions inputActions;
    public Vector2 movement { get; private set; }
    public bool isMoving { get; private set; }
    protected override void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        this.inputActions = new InputSystem_Actions();
    }
    protected override void OnEnable()
    {
        this.inputActions.Enable();
        this.inputActions.Player.Move.performed += OnMovementPerformed;
        this.inputActions.Player.Move.canceled += OnMovementCanceled;

        this.inputActions.Player.Jump.performed +=  OnJumpPerformed; 
        this.inputActions.Player.Jump.canceled += OnJumpCanceled;

    }
    protected override void OnDisable()
    {
        this.inputActions.Disable();
        this.inputActions.Player.Move.performed -= OnMovementPerformed;
        this.inputActions.Player.Move.canceled -= OnMovementCanceled;

        this.inputActions.Player.Jump.performed -=  OnJumpPerformed;
        this.inputActions.Player.Jump.canceled -= OnJumpCanceled;
    }
    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
    }
    private void OnJumpCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Jump Canceled");
    }
    private void OnMovementPerformed(InputAction.CallbackContext context)
    {
        this.isMoving = true;
        this.movement = context.ReadValue<Vector2>();
    }
    private void OnMovementCanceled(InputAction.CallbackContext context)
    {
        this.isMoving = false;
        this.movement = Vector2.zero;
    }
    
}
