using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.SearchService;

public class Player : SonMonoBehaviour
{
    [Header("Move Info")]
    [SerializeField] protected float moveSpeed = 5f;
    protected InputManager inputManager;
    protected Rigidbody2D rb2d;
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void LoadComponent()
    {
        this.rb2d = this.GetComponent<Rigidbody2D>();
        base.LoadComponent();
    }
    
    protected override void Start()
    {
        base.Start();
    }
    protected override void LoadSingleton()
    {
        this.inputManager = InputManager.instance;
        base.LoadSingleton();
    }
    protected override void Update()
    {
        base.Update();
        this.Move();
    }
    protected void Move()
    {
        // this.rb2d.linearVelocity = this.inputManager.movement * this.moveSpeed * Time.deltaTime;
        this.rb2d.linearVelocity = new Vector2(1, 0) * this.moveSpeed;
    }
}
