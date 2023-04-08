using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        score.instance.Addscore();
    }
}
