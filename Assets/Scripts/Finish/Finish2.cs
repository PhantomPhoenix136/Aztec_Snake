using UnityEngine;

public class Finish2 : MonoBehaviour
{
    public GameLogic2 GameLogic2;

    private void OnTriggerEnter(Collider other)
    {
        GameLogic2.OnWin();
    }
}
