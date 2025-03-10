using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

public class AffordanceCheck : MonoBehaviour
{
    [SerializeField] TMP_Text feedbackText;
    [SerializeField] GameObject victoryTextObj;

    public void CheckObject(SelectEnterEventArgs args)
    {
        GameObject obj = args.interactableObject.transform.gameObject;
        XRInteractableAffordanceStateProvider provider = obj.GetComponentInChildren<XRInteractableAffordanceStateProvider>();
        ColorMaterialPropertyAffordanceReceiver colorReceiver = obj.GetComponentInChildren<ColorMaterialPropertyAffordanceReceiver>();

        if (obj.tag != "AffordanceCheckCube")
        {
            feedbackText.text = "This cube isn't from this level, you can't fool me that easily :P";
        }
        else if (provider == null)
        {
            feedbackText.text = "XRInteractorAffordanceStateProvider is missing";
        }
        else if (provider.enabled == false)
        {
            feedbackText.text = "XRInteractorAffordanceStateProvider is disabled";
        }
        else if (provider.interactableSource == null)
        {
            feedbackText.text = "XRInteractorAffordanceStateProvider's source is missing";
        }
        else if (colorReceiver == null)
        {
            feedbackText.text = "ColorMaterialPropertyAffordanceReceiver is missing";
        }
        else if (colorReceiver.enabled == false)
        {
            feedbackText.text = "ColorMaterialPropertyAffordanceReceiver is disabled";
        }
        else if (colorReceiver.affordanceStateProvider == null)
        {
            feedbackText.text = "Receiver's state provider is not set";
        }
        else if (colorReceiver.affordanceThemeDatum == null || colorReceiver.affordanceThemeDatum.Value == null)
        {
            feedbackText.text = "Receiver's theme is not set";
        }
        else if (colorReceiver.materialPropertyBlockHelper == null)
        {
            feedbackText.text = "Receiver's block helper is not set";
        }
        else
        {
            victoryTextObj.SetActive(true);
            feedbackText.text = "";
        }
    }
}
