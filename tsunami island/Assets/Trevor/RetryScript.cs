﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour {

	void OnClick()
    {
        Debug.Log("fuck");
        SceneManager.LoadScene("MainSceneBetter", LoadSceneMode.Additive);
    }
}
