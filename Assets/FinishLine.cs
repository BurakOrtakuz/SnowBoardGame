using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    public void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            finishEffect.Play();
            Invoke("ReloadScene",delay);
        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
