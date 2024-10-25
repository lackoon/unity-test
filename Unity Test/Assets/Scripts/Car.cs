using UnityEngine;

public class Car : MonoBehaviour
{
    // suspension
    const float originalSuspensionLength = 1f;
    const float suspensionForce = 100f;
    Transform[] wheels;

    [SerializeField] Transform FrontLeftWheel;
    [SerializeField] Transform FrontRightWheel;
    [SerializeField] Transform BackLeftWheel;
    [SerializeField] Transform BackRightWheel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wheels = new Transform[] { FrontLeftWheel, FrontRightWheel, BackLeftWheel, BackRightWheel };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // add suspension force
        // add steering force + antislip to cancel out
        // add thrust
        // add braking
        // add drag
    }

    private void AddSuspensionForce(Transform wheel)
    {

    }
}