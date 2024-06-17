using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 _movedir { get; private set; }
    private TvContact _tvContact;
    public void ObjectGet()
    {
        _tvContact = FindObjectOfType<TvContact>();
    }
    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        _movedir = new Vector3(x, y);
    }

    public void IsTrigger()
    {
        StartCoroutine(IsTriggerTIme());
    }

    private IEnumerator IsTriggerTIme()
    {
        yield return null;
        _tvContact.BoxCollider.isTrigger = true;
    }

}
