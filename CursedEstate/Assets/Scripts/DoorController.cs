using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public float doorOpenRotation, doorCloseRotation, doorSpeed;
    public bool isDoorOpening;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = door.transform.localEulerAngles;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            toggleDoor();
        }

        if (isDoorOpening)
        {
            if (currentRotation.y < doorOpenRotation)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRotation, new Vector3(currentRotation.x, doorOpenRotation, currentRotation.z), doorSpeed * Time.deltaTime);

            }
        } 
        else
        {
            if (currentRotation.y > doorCloseRotation)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRotation, new Vector3(currentRotation.x, doorCloseRotation, currentRotation.z), doorSpeed * Time.deltaTime);

            }
        }
    }

    public void toggleDoor()
    {
        isDoorOpening = !isDoorOpening;
    }
}
