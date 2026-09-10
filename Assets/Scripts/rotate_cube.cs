using UnityEngine;

public class rotate_cube : MonoBehaviour
{

    [Header("Rotate Cube Settings")]
    // deefine rotation for cube
    public Vector3 RotationSpeed = new Vector3(0f, 50f, 25f); 

    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(RotationSpeed * Time.deltaTime);

    }
}
