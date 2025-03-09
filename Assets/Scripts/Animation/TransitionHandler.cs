using UnityEngine;
using UnityEngine.SceneManagement;

namespace Animation
{
	public class TransitionHandler : MonoBehaviour
	{
		[SerializeField] private string _nextScene = "";
		[SerializeField] private bool _disableFadeAnimation = false;


		private void Start()
		{
			if (_disableFadeAnimation)
			{
				Animator animator = gameObject.GetComponent<Animator>();
				animator.Play("FadeIn", 0, 1);
			}
		}

		private void FadeOutFinished()
		{
			SceneManager.LoadScene(_nextScene);
		}
	}
}
