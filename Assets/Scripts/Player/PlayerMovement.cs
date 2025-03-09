using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3.5f;
        [SerializeField] private float _jumpForce = 7.5f;
        private Rigidbody2D _rigidbody2D;
        private bool _isGround;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Jump();
            Move();
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _isGround)
            {
                _rigidbody2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
            }
        }

        private void Move()
        {
            float horizontalMovement = Input.GetAxis("Horizontal");
        
            transform.Translate(new Vector3(1, 0, 0) * (_speed * Time.deltaTime * horizontalMovement));
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Plat"))
                _isGround = true;         
        }
    
        private void OnCollisionExit2D(Collision2D collision)
        {
            if(collision.collider.CompareTag("Plat"))
                _isGround = false;
        }
    }
}
