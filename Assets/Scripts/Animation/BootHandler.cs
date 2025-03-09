using System.Collections;
using UnityEngine;

namespace Animation
{
    public class BootHandler : MonoBehaviour
    {
        [SerializeField] private Animator _fadeAnimator;

        private void Start()
        {
            StartCoroutine(Timer());
        }
    
        private IEnumerator Timer()
        {
            yield return new WaitForSeconds(2);
            _fadeAnimator.SetTrigger("FadeOut");
        }
    }
}
