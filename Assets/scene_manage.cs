using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manage : MonoBehaviour
{
	public void gotoScene(int scene_number)
	{
		SceneManager.LoadSceneAsync(scene_number);
	}
}
