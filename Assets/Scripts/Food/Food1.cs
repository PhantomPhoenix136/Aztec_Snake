using UnityEngine;

public class Food1 : MonoBehaviour
{
    public SnakeBlock SnakeBlock;
    public Player1 Player1;
    private int _value;
    private AudioSource _sound; 
    void Awake()
    {
        _sound = GetComponent<AudioSource>();
        _value = Random.Range(1, 6);
    }
    private void OnTriggerEnter(Collider other)
    {
        _sound.Play();
        SnakeBlock.ChangeSize(_value * 2);
        Player1.HP += _value;     
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Destroy(gameObject);
    }
}
