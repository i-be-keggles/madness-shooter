using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public int roomNumber;
    public Transform roomEntry;
    public Transform[] roomDoorLocations;
    public GameObject[] possibleRoomDoors;
    


    // Start is called before the first frame update
    void Start()
    {
        roomNumber = 1;
        for (int i = 0; i < roomDoorLocations.Length; i++)
        {
            Vector3 roomDoorPos = roomDoorLocations[i].position;
            var selectedDoor = Random.Range(0, possibleRoomDoors.Length - 1);
            Instantiate(possibleRoomDoors[selectedDoor], roomDoorPos, Quaternion.identity);
            Debug.Log(i);
            
        }
        Debug.Log(roomDoorLocations.Length);
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
