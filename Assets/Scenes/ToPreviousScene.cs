using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToPreviousScene : MonoBehaviour
{
	private int prevSceneToLoad;
	
    // Start is called before the first frame update
    public void ChangeToScene (int prevSceneToLoad)
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
		SceneManager.LoadScene(prevSceneToLoad);
    }

}
