using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRay : MonoBehaviour
{
    public Animator leftCamAnim;
    public Animator rightCamAnim;

    [SerializeField]Door door;

    InputMap map;
    public bool switchDoor => map.ActionMap.Action1.WasPressedThisFrame();

    private void Awake()
    {
        map = new InputMap();
        map.Enable();        
    }

    void Update() 
   {
       int layerMask = 1 << 8;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f, layerMask))
        {
            leftCamAnim.SetBool("Focus", true);
            rightCamAnim.SetBool("Focus", true);
            if (switchDoor)
            {
                door.Down();
                Debug.Log("00000");
            }
        }
        else 
        {
            leftCamAnim.SetBool("Focus", false);
            rightCamAnim.SetBool("Focus", false);
        }

   }
   
}
