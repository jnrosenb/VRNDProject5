using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameStart : MonoBehaviour {

	public GameObject canvas1;
	public GameObject canvas2;

	public void onClicked1()
	{
		canvas1.SetActive (false);
		canvas2.SetActive (true);
	}

	public void onClicked()
	{
		SceneManager.LoadScene (1);
	}
}
