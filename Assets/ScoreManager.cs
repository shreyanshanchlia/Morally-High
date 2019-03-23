using UnityEngine;
using UnityEngine.UI;
using BayatGames.SaveGameFree;

public class ScoreManager : MonoBehaviour
{
	public Image circle;
	public Text level;
	public tasksManager tasksManager;
	public void Update()
	{
		score();
	}
	public void score()
	{
		int score = SaveGame.Load<int>("score", 0);
		//score = 0;
		circle.fillAmount = (float)(score % 4) / 4.0f;
		level.text = ((int)score / 4).ToString();
	}
	public void addscore()
	{
		Debug.Log(tasksManager.pointsfortask);
		SaveGame.Save<int>("score", SaveGame.Load<int>("score", 0) + tasksManager.pointsfortask);
	}
}
