using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float _moveSpeed;
    private Transform _playerTransform;
    protected Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _playerTransform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    public abstract void MoveMethod();

    protected abstract void MovePlayer();

    

    protected void CheckViewDirection(Vector2? moveDirection)
    {
        if (moveDirection?.x < 0)
            RotateY(180);
        else if (moveDirection?.x > 0)
            RotateY(0);
    }

    private void RotateY(int angle)
    {
        _playerTransform.rotation = Quaternion.Euler(new Vector2(0, angle));
    }



}
