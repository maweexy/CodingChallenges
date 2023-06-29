using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnDrawGizmos(){
    Gizmos.color = Color.red;
    Gizmos.DrawWireCube(transform.position, new Vector3(1f,1f,1f));
    }
}
