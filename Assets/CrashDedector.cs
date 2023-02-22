using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDedector : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip  crashSFX;
    bool hasCrashed = false;
    public void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = false;
            FindObjectOfType<PlayerController>().disableController();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",delay);
            crashEffect.Play();
        }

    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
