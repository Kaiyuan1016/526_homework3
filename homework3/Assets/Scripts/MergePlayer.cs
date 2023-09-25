using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergePlayer : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {

        //if collision between player and electron happened
            //make electron merge into player and player change into larger size

        if (other.name == "Player1"){

            Destroy(this.gameObject);
            other.gameObject.transform.localScale += new Vector3(0.5f,0.5f,0.5f);

        }

    }

    void Update(){

    }


}
