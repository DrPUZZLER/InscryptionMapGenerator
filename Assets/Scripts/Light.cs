using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class Light : MonoBehaviour
{

    Light2D fireLight;
    [SerializeField] float rate = 0.01f;
    [SerializeField] float factor = .25f;
    [SerializeField] float startValue = 1.75f;
    void Start() {
        fireLight = gameObject.GetComponent<Light2D>();
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker() {
        while (true) {
            fireLight.intensity = Random.Range(startValue - factor, startValue + factor);
            yield return new WaitForSeconds(rate);
        }
        
    }
}
