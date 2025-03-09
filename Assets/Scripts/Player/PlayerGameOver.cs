using UnityEngine;

namespace Player
{
    public class PlayerGameOver : MonoBehaviour
    {
        [SerializeField] private Transform _player;
    
        private Transform _playerPosition;
        private Vector3 _position;
    
        private void Start()
        {
            _playerPosition = _player.GetComponent<Transform>();
        
            _position.x = _playerPosition.position.x;
            _position.y = _playerPosition.position.y;
            _position.z = _playerPosition.position.z;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Respawn"))
            {
                _playerPosition.position = _position;
            }
        }
    }
}
