using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //VARIABLES QUE RECONOCER EL PLAYER Y LA POSICION DE LA CAMARA
    public GameObject player;
    private Vector3 offset = new Vector3(49.2f, 3.7f, 21.2f);

    // Update is called once per frame
    private void LateUpdate()
    {
        //LA CAMARA SIGUE AL JUGADOR
        transform.position = player.transform.position + offset;

    }
}
