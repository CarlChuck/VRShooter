using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public OVRGrabber rightHand;

    [SerializeField] private GameObject rightHandHeld;

    public GameObject canvas;
    private bool canvasActive = true;

    //UI Panes    
    public GameObject startPane;
    public GameObject introPane;

    
    private void Start()
    {
        ActivatePane(introPane);
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            if (rightHandHeld.GetComponent<HeldItem>())
            {
                rightHandHeld.GetComponent<HeldItem>().OnTriggerPress();
            }
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            canvasActive = !canvasActive;
            canvas.SetActive(canvasActive);
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
        {

        }
        if (OVRInput.GetDown(OVRInput.Button.One))//A
        {

        }
        if (OVRInput.GetDown(OVRInput.Button.Two))//B
        {

        }
        if (OVRInput.GetDown(OVRInput.Button.Three))//X
        {

        }
        if (OVRInput.GetDown(OVRInput.Button.Four))//Y
        {
            ActivatePane(startPane);
        }
        UpdateHeldItem();
    }

    private void UpdateHeldItem()
    {
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {
            rightHandHeld = rightHand.grabbedObject.gameObject;

        }
        else
        {
            rightHandHeld = null;
        }
    }

    private void ActivatePane(GameObject pane)
    {
        startPane.SetActive(false);
        introPane.SetActive(false);
        pane.SetActive(true);
    }
}