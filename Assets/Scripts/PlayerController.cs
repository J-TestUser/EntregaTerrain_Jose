using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    //General Variables
    [SerializeField] private float _movementSpeed = 10;
    [SerializeField] private float _jumpHeight = 2;

    //Specific Variables
    private float _trunSmoothVelocity = 10;
    [SerializeField] private float _smoothTime = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
