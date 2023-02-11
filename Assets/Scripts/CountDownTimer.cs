using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    private float timerDuration = 2f * 60f;

    [SerializeField] private float timer;
    [SerializeField] private GameObject minuteArrow;

    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        timer = timerDuration;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            minuteArrow.transform.localRotation = Quaternion.Euler(0f, 0f, timer * 6f + 40);
        }
        else
        {
            StartCoroutine(clock());
        }
    }

    IEnumerator clock()
    {
        _audioSource.enabled = true;
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
