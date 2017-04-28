using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameStart : MonoBehaviour {

	public void onClicked()
	{
		SceneManager.LoadScene(1);
	}
}
