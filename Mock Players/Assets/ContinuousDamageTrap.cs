using UnityEngine;

public class ContinuousDamageTrap : MonoBehaviour
{
    [SerializeField]
    private TrapType trapType;
    private Trap trap;
    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerStay(Collider other)
    {
        var characterMover = other.GetComponent<Player>();
        trap.HandleCharacterEntered(characterMover, trapType);
    }
}
