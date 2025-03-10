using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseToDoList : MonoBehaviour
{
    [Header("Section 1")]

    [Tooltip("Learn controls of the device simulator before trying to fix things. Look around, learn to teleport, grab some of the cubes")]
    public bool LearnDeviceSimulatorControls;

    [Tooltip("Fix the anchor inbetween levels 1 and 2 to make it across the large gap")]
    public bool FixTeleportationAnchor;

    [Header("Section 2")]
    [Tooltip("Make the cube in level 2 grabbable and place it in the socket interactor")]
    public bool MakeCubeGrabbable;

    [Header("Section 3")]
    [Tooltip("Make the UI button interact with XR interactors")]
    public bool AddUIInteraction;

    [Tooltip("Make the push button interactable")]
    public bool FixPushButtonInteraction;

    [Tooltip("Add the event to the button so it removes the wall")]
    public bool MakePushButtonTriggerEvent;


    [Header("Section 4")]

    [Tooltip("Add affordances back onto the cube, then place it in the checker socket")]
    public bool AddAffordanceToCube;
}
