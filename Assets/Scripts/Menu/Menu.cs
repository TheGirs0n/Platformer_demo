using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class Menu : MonoBehaviour
    {
        public void ChooseLevel() 
        {
            SceneManager.LoadScene("LevelChoose");
        }
        
        public void Exit() 
        {
            Application.Quit();
        }
    }
}
