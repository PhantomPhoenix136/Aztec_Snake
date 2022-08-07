using UnityEngine;

public class Finish1 : MonoBehaviour
{
    public GameLogic1 GameLogic1;

    private void OnTriggerEnter(Collider other)
    {
        GameLogic1.OnWin();
    }
}
