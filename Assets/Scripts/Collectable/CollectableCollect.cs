using Audio;
using Game;
using UnityEngine;

namespace Collectable
{
    public class CollectableCollect : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _victoryText;
        [SerializeField] private GameObject _score;
        [SerializeField] private GameObject _audioObject;
        private AudioPlay _audio;
        private LevelScore _levelScore;
    
        private void Start()
        {
            _levelScore = _score.GetComponent<LevelScore>();
            _audio = _audioObject.GetComponent<AudioPlay>();
        }
    
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Collectable"))
            {
                collision.gameObject.SetActive(false);
            
                _levelScore._text.text = $"{++_levelScore._counter}/{_levelScore.MaxCounter}";
            
                if(_levelScore._counter != _levelScore.MaxCounter)
                    _audio.GetCollectable();
                else
                    _audio.Victory();
            }
        }
    
        private void Update()
        {
            if (_levelScore._counter == _levelScore.MaxCounter)       
                _victoryText.SetActive(true);                  
        }
    }
}
