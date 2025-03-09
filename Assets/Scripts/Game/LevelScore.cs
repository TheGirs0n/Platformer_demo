using TMPro;
using UnityEngine;

namespace Game
{
    public class LevelScore : MonoBehaviour
    {
        [SerializeField] public TextMeshProUGUI _text;
        [SerializeField] public int _counter = 0;
        [SerializeField] public GameObject _collectables;

        private int _maxCounter;
        public int MaxCounter => _maxCounter;
    
        private void Awake()
        {
            _maxCounter = _collectables.GetComponentsInChildren<Transform>().Length - 1;
            _text.text = $"0/{_maxCounter}";
        }
    }
}
