using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
public void FirstScene(){
    SceneManager.LoadSceneAsync(1);
}

public void SecondScene(){
    SceneManager.LoadSceneAsync(2);
}

public void ThirdScene(){
    SceneManager.LoadSceneAsync(3);
}

public void OriginalScene(){
    SceneManager.LoadSceneAsync(0);
}
}
