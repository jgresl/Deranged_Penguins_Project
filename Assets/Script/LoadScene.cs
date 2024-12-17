using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Reload the active scene
/// </summary>
public class LoadScene : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}