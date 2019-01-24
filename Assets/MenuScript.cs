using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void Scene1()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
	public void Scene2()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
	}
	public void Scene3()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
	}
	public void Scene4()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
	}
}
