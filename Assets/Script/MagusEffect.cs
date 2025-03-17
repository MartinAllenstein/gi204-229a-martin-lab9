using UnityEngine;

public class MagusEffect : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] Vector3 velocity ,spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
        }
        ApplyMagnusEffect();
    }

    void Kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 mangusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);
        
        rb.AddForce(mangusForce, ForceMode.Force);
    }
}
