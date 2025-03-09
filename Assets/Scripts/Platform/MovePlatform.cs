using System.Collections;
using UnityEngine;

namespace Platform
{
    public class MovePlatform : MonoBehaviour
    {
        [SerializeField] private GameObject _platformPathStart;
        [SerializeField] private GameObject _platformPathEnd;
        [SerializeField] private int _speed;
        
        private Rigidbody2D _rigidbody2D;
        private Vector2 _startPosition;
        private Vector2 _endPosition;
    

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        
            _startPosition = _platformPathStart.transform.position;
            _endPosition = _platformPathEnd.transform.position;
        
            StartCoroutine(MovePlatformCoroutine(gameObject, _endPosition, _speed));
        }

        private void Update()
        {
            if (_rigidbody2D.position == _endPosition)
            {
                StartCoroutine(MovePlatformCoroutine(gameObject, _startPosition, _speed));
            }
        
            if (_rigidbody2D.position == _startPosition)
            {
                StartCoroutine(MovePlatformCoroutine(gameObject, _endPosition, _speed));
            }
        }

        private IEnumerator MovePlatformCoroutine(GameObject obj, Vector2 target, float speed)
        {
            Vector2 startPosition = obj.transform.position;
            float time = 0f;

            while (_rigidbody2D.position != target)
            {
                obj.transform.position = Vector2.Lerp(startPosition, target, (time / Vector2.Distance(startPosition, target)) * speed);
                time += Time.deltaTime;
                yield return null;
            }
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            col.gameObject.transform.SetParent(gameObject.transform, true);
        }

        private void OnCollisionExit2D(Collision2D col)
        {
            col.gameObject.transform.parent = null;
        }
    }
}