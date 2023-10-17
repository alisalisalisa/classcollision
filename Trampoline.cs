using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //rritja e kercimit
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    void OnTriggerExit(Collider other)
    {
        //reduktimi i kercimit
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
