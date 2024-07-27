using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ivent_Trigger : MonoBehaviour
{
    private PlayableDirector timeline;
    private void Awake()
    {
        timeline = GetComponent<PlayableDirector>();
    }
    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }
}
