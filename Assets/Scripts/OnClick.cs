using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            if(Physics.Raycast(ray ,out hitInfo))
            {
                IDamageable damageable = hitInfo.collider.GetComponent<IDamageable>();
                // Mouse t�kland���nda kameran�n hizas�nda ray olu�tur ve t�klanan objede IDamageable varsa hasar ver

                if (damageable != null)
                {
                    damageable.TakeDamege(10);
                }

            }
        }
    }
}
