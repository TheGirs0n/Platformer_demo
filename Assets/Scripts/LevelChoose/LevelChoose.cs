using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelChoose
{
    public class LevelChoose : MonoBehaviour
    {
        public void LoadLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
