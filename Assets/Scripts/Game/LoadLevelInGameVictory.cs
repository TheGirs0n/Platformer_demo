using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class LoadLevelInGameVictory : MonoBehaviour
    {
        public void LoadNextLevel(string nextLevel)
        {
            SceneManager.LoadScene(nextLevel);
        }
    
        public void LoadPreviosLevel(string previosLevel)
        {
            SceneManager.LoadScene(previosLevel);
        }
    
        public void LoadMenu(string menu)
        {
            SceneManager.LoadScene(menu);
        }
    }
}
