using System.Collections;
using UnityEngine;
using TMPro;


public class Obstacle2 : MonoBehaviour
{
    private int _basepower;
    private int _maxpower;
    public SnakeBlock SnakeBlock;
    public Player2 Player2;
    private readonly float _colorMultiplier = 0.04f;
    public TMP_Text _text;
    private ParticleSystem _particleSystem;
    void Awake()
    {
        _basepower = Random.Range(1, 11);
        _maxpower = _basepower;
        gameObject.GetComponent<Renderer>().material.SetFloat("Power", _basepower * _colorMultiplier);
        _text.text = _basepower.ToString();
        _particleSystem = GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Crash());
    }

    IEnumerator Crash()
    {
        while (_basepower > 0 && Player2.HP > 0)
        {
            yield return new WaitForSeconds(0.1f);
            _particleSystem.Play();
            _basepower--;
            Player2.HP--;
            _text.text = _basepower.ToString();
        }
        if (SnakeBlock.transform.localScale.y > 1) SnakeBlock.ChangeSize(-_maxpower);
        if (Player2.HP >= 1 || _basepower == 0) Destroy(gameObject);
        else Player2.GameLogic2.OnDeath();        
    }
    private void OnCollisionExit(Collision collision)
    {
        StopAllCoroutines();
    }
}
