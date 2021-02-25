using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar : MonoBehaviour
{
    public GameObject ObjectToPickup;
    public GameObject TomarObjeto;
    public Transform interactionZone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToPickup!= null && ObjectToPickup.GetComponent<Tomar>().isPickable==true && TomarObjeto==null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TomarObjeto = ObjectToPickup;
                TomarObjeto.GetComponent<Tomar>().isPickable = false;
                TomarObjeto.transform.SetParent(interactionZone);
                TomarObjeto.transform.position = interactionZone.position;
                TomarObjeto.GetComponent<Rigidbody>().useGravity = false;
                TomarObjeto.GetComponent<Rigidbody>().isKinematic = true;

            }
            else if (TomarObjeto != null)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    TomarObjeto.GetComponent<Tomar>().isPickable = true;
                    TomarObjeto.transform.SetParent(null);
                    
                    TomarObjeto.GetComponent<Rigidbody>().useGravity = true ;
                    TomarObjeto.GetComponent<Rigidbody>().isKinematic = false ;
                    TomarObjeto = null;


                }

            }
        }
    }
}
