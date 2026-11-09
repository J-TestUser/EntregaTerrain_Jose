using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    [SerializeField] int _sunRotationSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (_sunRotationSpeed * Time.deltaTime, 0, 0);
    }
}
