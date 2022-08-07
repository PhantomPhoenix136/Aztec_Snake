using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusEffect : MonoBehaviour
{
    public Player Player;
    private ParticleSystem CactusEffectParticle;
    private AudioSource _sound;

    void Awake()
    {
        CactusEffectParticle = GetComponent<ParticleSystem>();
        _sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        CactusEffectParticle.GetComponent<ParticleSystem>().Play();
        _sound.Play();
    }
    IEnumerator stopWinEffect()
    {
        yield return new WaitForSeconds(.4f);
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Destroy(gameObject);
    }
}

