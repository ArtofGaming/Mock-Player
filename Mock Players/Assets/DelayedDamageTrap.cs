using UnityEngine;

public class DelayedDamageTrap : MonoBehaviour
{
    [SerializeField]
    private TrapType trapType;
    private Trap trap;
    private float timeTilFall = 5f;
    private float timer = 0;
    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        var characterMover = other.GetComponent<Player>();
        if(timer >= timeTilFall)
        {
            this.gameObject.SetActive(false);
            trap.HandleCharacterEntered(characterMover, trapType);
            other.gameObject.transform.position = new Vector3(0, 1.5f, 0);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        timer = 0;
    }
}
