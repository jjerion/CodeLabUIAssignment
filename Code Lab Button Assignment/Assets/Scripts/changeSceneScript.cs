using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoLongBeach()
    {
        SceneManager.LoadScene("LongBeach"); //switch to long beach scene
    }

    public void GotoOlympia()
    {
        SceneManager.LoadScene("Olympia"); //switch to olympia scene
    }
}
