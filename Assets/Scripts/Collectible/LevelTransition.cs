﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Im good");
        if (other.transform.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }
}
