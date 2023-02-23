using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float fForce;
    [SerializeField]
    private Rigidbody2D rRigidbody2D;

    private void OnMouseDown()
    {
        this.rRigidbody2D.AddForce(new Vector2(UnityEngine.Random.Range(-1f, 1f), 1f * this.fForce), ForceMode2D.Impulse);
    }
}
