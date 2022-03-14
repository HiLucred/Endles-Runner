using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Animator _cameraShakeAnimation;

    private void Awake()
    {
        _cameraShakeAnimation = GetComponent<Animator>();
    }

    public void ShakeTheCamera()
    {
        StartCoroutine(ShakeTheCameraCoroutine());
    }

    private IEnumerator ShakeTheCameraCoroutine()
    {
        _cameraShakeAnimation.SetBool("Shake", true);
        yield return new WaitForSeconds(1f);
        _cameraShakeAnimation.SetBool("Shake", false);
    }
}