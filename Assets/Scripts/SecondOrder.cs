using UnityEngine;

public class SecondOrder : MonoBehaviour
{
    public enum Mode
    {
        Position,
        Velocity,
        Acceleration
    }
    
    public Mode updateMode;
    
    [Range(0,10)] public float F;
    [Range(0,10)] public float Z;
    [Range(0,10)] public float R;
    
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
