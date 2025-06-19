using UnityEngine;

namespace Audio
{
    public class AudioPlay : MonoBehaviour
    {
        [SerializeField] private AudioClip[] _clips;
        [SerializeField] private AudioSource _sound;

        public void GetCollectable()
        {
            _sound.clip = _clips[0];
            _sound.volume = 0.75f;
            _sound.Play();
        }
        
        public void Victory()
        {
            _sound.clip = _clips[1];
            _sound.volume = 0.75f;
            _sound.Play();
        }
    }
}
