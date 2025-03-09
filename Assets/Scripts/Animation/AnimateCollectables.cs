using UnityEngine;

namespace Animation
{
    public class AnimateCollectables : MonoBehaviour
    {
        [SerializeField] private Transform[] _Collectiables;

        private void Awake()
        {
            _Collectiables = gameObject.GetComponentsInChildren<Transform>();
        }
        
        private void Update()
        {
            for(int i = 1; i < _Collectiables.Length; i++) 
            {
                if (_Collectiables[i] is not null)
                    _Collectiables[i]!.transform.Rotate(new Vector3(0, 0, 1) * (25.0f * Time.deltaTime));
            }
        }
    }
}
