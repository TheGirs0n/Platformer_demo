using UnityEngine;

namespace UI
{
    public class BackgroundMoveUI : MonoBehaviour
    {
        [SerializeField] private GameObject _background;

        private Vector3 _moveVector;

        private float _backgroundOriginalSizeX = 0;
        private float _backgroundOriginalSizeY = 0;

        private void Start()
        {
            SpriteRenderer spriteRenderer = _background.GetComponent<SpriteRenderer>();
            
            var originalSize = spriteRenderer.size;
            _backgroundOriginalSizeX = originalSize.x;
            _backgroundOriginalSizeY = originalSize.y;

            _moveVector = new Vector3(0.5f, 0.25f, 0);

            spriteRenderer.size = new Vector2(_backgroundOriginalSizeX * 2,  + _backgroundOriginalSizeY * 2);
        }
    
        private void Update()
        {
            _background.transform.Translate(-_moveVector.x * Time.deltaTime, -_moveVector.y * Time.deltaTime, 0);

            if (_background.transform.position.x >= _backgroundOriginalSizeX / 2)
            {
                _background.transform.Translate(_backgroundOriginalSizeX, 0, 0);
            }
            if (_background.transform.position.x <= -_backgroundOriginalSizeX / 2)
            {
                _background.transform.Translate(_backgroundOriginalSizeX, 0, 0);
            }
            if (_background.transform.position.y >= _backgroundOriginalSizeY / 2)
            {
                _background.transform.Translate(0, -_backgroundOriginalSizeY, 0);
            }
            if (_background.transform.position.y <= -_backgroundOriginalSizeY / 2)
            {
                _background.transform.Translate(0, _backgroundOriginalSizeY, 0);
            }
        }
    }
}
