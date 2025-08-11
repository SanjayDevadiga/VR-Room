using System;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    [SerializeField] GameObject secondHandle;
    [SerializeField] GameObject minuteHandle;
    [SerializeField] GameObject hourHandle;

    void Update()
    {
        DateTime date = DateTime.Now;
        secondHandle.transform.rotation = Quaternion.Euler(date.Second * 6, 0, 0);
        minuteHandle.transform.rotation = Quaternion.Euler(date.Minute * 6, 0, 0);
        hourHandle.transform.rotation = Quaternion.Euler((date.Hour % 12) * 30, 0, 0);
    }
}
