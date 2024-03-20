using UnityEngine;
using UnityEngine.SceneManagement;

public class goToScene : MonoBehaviour
{
    public int _scene = -1;

    public void _goToScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + _scene);
    }
}
