using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
	public GameObject startUI, restartUI;

	public void ToggleUI()
	{
		startUI.SetActive(!startUI.activeSelf);
		restartUI.SetActive(!restartUI.activeSelf);
	}

	// Placeholder method to prevent compiler errors caused by this method being called from LightUp.cs.
	public void PlayerSelection(GameObject sphere)
	{
		// Will be completed later in the course.
	}

	public void DelayedGaze() {
		StartCoroutine ("delayInput");
	}

	IEnumerator delayInput() {
		yield return new WaitForSeconds (1);
		ToggleUI ();
	}
}
