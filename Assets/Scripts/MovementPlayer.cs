using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 3f;
    [SerializeField] private float _walkSpeed = 3f;
    [SerializeField] private PlayerInput _playerInput;
    private void Start()
    { 
        if (_playerInput == null)
            _playerInput.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);

        print("the player movement script is loaded in");
    }
    public void MovePlayerSideWays(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _walkSpeed * Time.deltaTime;
    }
    public void MovePlayerUp(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _jumpPower * Time.deltaTime;
    }
}
