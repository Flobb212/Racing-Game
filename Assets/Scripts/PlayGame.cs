using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour
{
	public string levelName = "RacingGameLevel";

	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}
