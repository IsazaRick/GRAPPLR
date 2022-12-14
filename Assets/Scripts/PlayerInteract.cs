using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Camera cam;
    [SerializeField]
    private LayerMask mask;
    [SerializeField]
    private float distance = 3f;
    private PlayerUI playerUI;
    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }
    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.BaseInteract();
                }
            }
        }

    }
}
